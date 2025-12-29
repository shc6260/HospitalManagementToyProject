using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyProject.Core.Helper;
using ToyProject.Model;
using ToyProject.Model.Dto;
using ToyProject.Model.Type;

namespace ToyProject.Core.Repositories.InMemory
{
    public class InMemoryPatientRepository : IPatientRepository
    {
        private readonly InMemoryRepositoryContext _context;

        public InMemoryPatientRepository(InMemoryRepositoryContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<PatientResponseDto>> FindPatientsForGnbAsync(string searchText)
        {
            var query = _context.Patients.AsEnumerable();

            if (string.IsNullOrWhiteSpace(searchText) == false)
            {
                query = query.Where(p =>
                    (p.Name ?? string.Empty).IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0
                    || (p.ChartNumber ?? string.Empty).IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0
                    || (p.PhoneNumber ?? string.Empty).IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0
                    || (p.Social_Security_Number ?? string.Empty).IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            return Task.FromResult(query);
        }

        public Task<long> AddPatientsAsync(PatientAddRequestDto dto)
        {
            var id = _context.NextPatientId();
            var patient = new PatientResponseDto
            {
                Id = id,
                ChartNumber = $"P{id:D4}",
                Name = dto.Name,
                Social_Security_Number = dto.Social_Security_Number,
                Gender = string.Empty,
                PhoneNumber = dto.PhoneNumber,
                Address = dto.Address,
                Memo = dto.Memo,
                Qualification_Info = dto.Qualification_Info
            };

            _context.Patients.Add(patient);
            return Task.FromResult(id);
        }

        public Task<long> ModifyPatientsAsync(PatientRequestDto dto)
        {
            var patient = _context.Patients.FirstOrDefault(p => p.Id == dto.Id);
            if (patient != null)
            {
                patient.Name = dto.Name ?? patient.Name;
                patient.Social_Security_Number = dto.Social_Security_Number ?? patient.Social_Security_Number;
                patient.PhoneNumber = dto.PhoneNumber ?? patient.PhoneNumber;
                patient.Address = dto.Address ?? patient.Address;
                patient.Memo = dto.Memo ?? patient.Memo;
                patient.Qualification_Info = dto.Qualification_Info ?? patient.Qualification_Info;
            }

            return Task.FromResult(dto.Id ?? -1);
        }
    }

    public class InMemoryTesterRepository : ITesterRepository
    {
        private readonly InMemoryRepositoryContext _context;
        private DateTime _lastUpdated = DateTime.Now;

        public InMemoryTesterRepository(InMemoryRepositoryContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<TesterResponseDto>> FindAll()
        {
            return Task.FromResult(_context.Testers.AsEnumerable());
        }

        public Task<bool> HasChanged(DateTime checkTime)
        {
            return Task.FromResult(_lastUpdated > checkTime);
        }

        public Task AddTester(TesterAddRequestDto dto)
        {
            _context.Testers.Add(new TesterResponseDto
            {
                Id = _context.NextTesterId(),
                License_Number = dto.License_Number,
                Name = dto.Name,
                Office_Info = dto.Office_Info,
                Enabled = true
            });

            Touch();
            return Task.CompletedTask;
        }

        public Task ModifyTester(TesterRequestDto dto)
        {
            var tester = _context.Testers.FirstOrDefault(t => t.Id == dto.Id);
            if (tester != null)
            {
                tester.License_Number = dto.License_Number ?? tester.License_Number;
                tester.Name = dto.Name ?? tester.Name;
                tester.Office_Info = dto.Office_Info ?? tester.Office_Info;
                tester.Enabled = dto.Enabled;
                Touch();
            }

            return Task.CompletedTask;
        }

        public Task DeleteTester(long id)
        {
            _context.Testers.RemoveAll(t => t.Id == id);
            Touch();
            return Task.CompletedTask;
        }

        private void Touch()
        {
            _lastUpdated = DateTime.Now;
        }
    }

    public class InMemoryTestItemRepository : ITestItemRepository
    {
        private readonly InMemoryRepositoryContext _context;
        private DateTime _lastUpdated = DateTime.Now;

        public InMemoryTestItemRepository(InMemoryRepositoryContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<TestItemResponseDto>> FindAll()
        {
            return Task.FromResult(_context.TestItems.AsEnumerable());
        }

        public Task<bool> HasChanged(DateTime checkTime)
        {
            return Task.FromResult(_lastUpdated > checkTime);
        }

        public Task AddTestItem(TestItemAddRequestDto dto)
        {
            _context.TestItems.Add(new TestItemResponseDto
            {
                Id = _context.NextTestItemId(),
                TestItemCode = dto.TestItemCode,
                Name = dto.Name,
                Reference_Min_Value = dto.Reference_Min_Value.Value,
                Reference_Max_Value = dto.Reference_Max_Value.Value,
                Enabled = true
            });

            Touch();
            return Task.CompletedTask;
        }

        public Task ModifyTestItem(TestItemRequestDto dto)
        {
            var item = _context.TestItems.FirstOrDefault(t => t.Id == dto.Id);
            if (item != null)
            {
                item.TestItemCode = dto.TestItemCode ?? item.TestItemCode;
                item.Name = dto.Name ?? item.Name;
                item.Reference_Min_Value = dto.Reference_Min_Value == default ? item.Reference_Min_Value : dto.Reference_Min_Value.Value;
                item.Reference_Max_Value = dto.Reference_Max_Value == default ? item.Reference_Max_Value : dto.Reference_Max_Value.Value;
                item.Enabled = dto.Enabled;
                Touch();
            }

            return Task.CompletedTask;
        }

        public Task DeleteTestItem(long id)
        {
            _context.TestItems.RemoveAll(t => t.Id == id);
            Touch();
            return Task.CompletedTask;
        }

        private void Touch()
        {
            _lastUpdated = DateTime.Now;
        }
    }

    public class InMemoryEquipmentRepository : IEquipmentRepository
    {
        private readonly InMemoryRepositoryContext _context;
        private DateTime _lastUpdated = DateTime.Now;

        public InMemoryEquipmentRepository(InMemoryRepositoryContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<EquipmentResponseDto>> FindAll()
        {
            return Task.FromResult(_context.Equipments.AsEnumerable());
        }

        public Task<bool> HasChanged(DateTime checkTime)
        {
            return Task.FromResult(_lastUpdated > checkTime);
        }

        public Task AddEquipment(EquipmentAddRequestDto dto)
        {
            _context.Equipments.Add(new EquipmentResponseDto
            {
                Id = _context.NextEquipmentId(),
                EquipmentCode = dto.EquipmentCode,
                Name = dto.Name,
                Enabled = true
            });

            Touch();
            return Task.CompletedTask;
        }

        public Task ModifyEquipment(EquipmentRequestDto dto)
        {
            var equipment = _context.Equipments.FirstOrDefault(e => e.Id == dto.Id);
            if (equipment != null)
            {
                equipment.EquipmentCode = dto.EquipmentCode ?? equipment.EquipmentCode;
                equipment.Name = dto.Name ?? equipment.Name;
                equipment.Enabled = dto.Enabled;
                Touch();
            }

            return Task.CompletedTask;
        }

        public Task DeleteEquipment(long id)
        {
            _context.Equipments.RemoveAll(e => e.Id == id);
            Touch();
            return Task.CompletedTask;
        }

        private void Touch()
        {
            _lastUpdated = DateTime.Now;
        }
    }

    public class InMemoryReceptionRepository : IReceptionRepository
    {
        private readonly InMemoryRepositoryContext _context;

        public InMemoryReceptionRepository(InMemoryRepositoryContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<ReceptionWithPatientSimpleResponseDto>> FindReceptionWithPatientInfo(DateTime from, DateTime to)
        {
            var receptions = _context.Receptions
                .Where(r => r.ReceptionDate >= from.Date && r.ReceptionDate.Date <= to)
                .Select(r =>
                {
                    var patient = _context.Patients.FirstOrDefault(p => p.Id == r.PatientId);
                    return new ReceptionWithPatientSimpleResponseDto
                    {
                        Id = r.Id,
                        Reception_dt = r.ReceptionDate,
                        PatientName = patient?.Name,
                        Chartnumber = patient?.ChartNumber
                    };
                })
                .ToList();

            return Task.FromResult<IEnumerable<ReceptionWithPatientSimpleResponseDto>>(receptions);
        }

        public Task<IEnumerable<ReceptionResponseDto>> FindReceptionWithTests(long id)
        {
            var reception = _context.Receptions.FirstOrDefault(r => r.Id == id);
            if (reception == null)
                return Task.FromResult(Enumerable.Empty<ReceptionResponseDto>());

            var tests = _context.Tests.Where(t => t.ReceptionId == id).ToList();
            var list = new List<ReceptionResponseDto>();

            foreach (var test in tests)
            {
                var item = _context.TestItems.FirstOrDefault(i => i.Id == test.TestItemId);

                list.Add(new ReceptionResponseDto
                {
                    Id = reception.Id,
                    Patient_Id = reception.PatientId,
                    Emergency = reception.Emergency,
                    Night = reception.Night,
                    Memo = reception.Memo,
                    Insured_info = reception.InsuredInfo,
                    Specifical_code = reception.SpecificalCode,
                    Insurance_info = reception.InsuranceInfo,
                    Checkup_target_info = reception.CheckupTargetInfo,
                    Reception_dt = reception.ReceptionDate,
                    Test_Id = test.Id,
                    Test_Code = test.TestCode,
                    Test_Name = test.TestName,
                    Status = test.Status,
                    TestItem_id = test.TestItemId,
                    TestItem_Name = item.Name
                });
            }

            return Task.FromResult<IEnumerable<ReceptionResponseDto>>(list);
        }

        public Task AddReception(ReceptionAddRequestDto dto, IEnumerable<TestAddRequestDto> tests)
        {
            var reception = new ReceptionRecord
            {
                Id = _context.NextReceptionId(),
                PatientId = dto.Patient_Id,
                Emergency = dto.Emergency,
                Night = dto.Night,
                Memo = dto.Memo,
                InsuredInfo = dto.Insured_info,
                SpecificalCode = dto.Specifical_code,
                InsuranceInfo = dto.Insurance_info,
                CheckupTargetInfo = dto.Checkup_target_info,
                ReceptionDate = dto.Reception_dt
            };

            _context.Receptions.Add(reception);

            if (tests != null)
            {
                foreach (var test in tests)
                {
                    var ids = (test.TestItemIds ?? string.Empty)
                        .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(id =>
                        {
                            long.TryParse(id, out var value);
                            return value;
                        })
                        .ToArray();

                    var testcode = Guid.NewGuid();

                    foreach (var itemId in ids)
                    {
                        _context.Tests.Add(new TestRecord
                        {
                            Id = _context.NextTestId(),
                            TestCode = testcode,
                            ReceptionId = reception.Id,
                            TestName = test.TestName,
                            Status = StatusType.Reception,
                            TestItemId = itemId
                        });
                    }
                }
            }

            return Task.CompletedTask;
        }

        public Task ModifyReception(ReceptionModifyRequestDto dto)
        {
            var reception = _context.Receptions.FirstOrDefault(r => r.Id == dto.Id);
            if (reception != null)
            {
                reception.Emergency = dto.Emergency;
                reception.Night = dto.Night;
                reception.Memo = dto.Memo;
                reception.InsuredInfo = dto.Insured_info;
                reception.SpecificalCode = dto.Specifical_code;
                reception.InsuranceInfo = dto.Insurance_info;
                reception.CheckupTargetInfo = dto.Checkup_target_info;
                reception.ReceptionDate = dto.Reception_dt ?? reception.ReceptionDate;
            }

            return Task.CompletedTask;
        }

        public Task DeleteReception(long id)
        {
            var testIds = _context.Tests.Where(t => t.ReceptionId == id).Select(t => t.Id).ToArray();
            _context.TestResults.RemoveAll(tr => testIds.Contains(tr.TestId));
            _context.Tests.RemoveAll(t => t.ReceptionId == id);
            _context.Receptions.RemoveAll(r => r.Id == id);
            return Task.CompletedTask;
        }
    }

    public class InMemoryTestRepository : ITestRepository
    {
        private readonly InMemoryRepositoryContext _context;

        public InMemoryTestRepository(InMemoryRepositoryContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<TestDetailDto>> GetTestsAsync(StatusType? status = null, long? patientId = null)
        {
            var tests = _context.Tests.AsEnumerable();

            if (status.HasValue)
                tests = tests.Where(t => t.Status == status.Value);

            var result = new List<TestDetailDto>();

            foreach (var test in tests)
            {
                var reception = _context.Receptions.FirstOrDefault(r => r.Id == test.ReceptionId);
                if (patientId.HasValue && reception?.PatientId != patientId.Value)
                    continue;

                var patient = _context.Patients.FirstOrDefault(p => p.Id == reception?.PatientId);
                var results = _context.TestResults.Where(tr => tr.TestId == test.Id).ToList();
                var resultsOrDefault = results.Any() ? results : new List<TestResultRecord> { null };

                var item = _context.TestItems.FirstOrDefault(i => i.Id == test.TestItemId);

                foreach (var res in resultsOrDefault)
                {
                    result.Add(CreateTestDetailDto(test, reception, patient, item, res));
                }
            }

            return Task.FromResult<IEnumerable<TestDetailDto>>(result);
        }

        public Task AddTestsAsync(IEnumerable<TestAddRequestDto> tests, long receptionId)
        {
            foreach (var test in tests)
            {
                var ids = (test.TestItemIds ?? string.Empty)
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(id =>
                    {
                        long.TryParse(id, out var value);
                        return value;
                    })
                    .ToArray();

                var testcode = Guid.NewGuid();

                foreach (var itemId in ids)
                {
                    _context.Tests.Add(new TestRecord
                    {
                        Id = _context.NextTestId(),
                        TestCode = testcode,
                        ReceptionId = receptionId,
                        TestName = test.TestName,
                        Status = StatusType.Reception,
                        TestItemId = itemId
                    });
                }
            }

            return Task.CompletedTask;
        }

        public Task ModifyTestsAsync(IEnumerable<TestModifyRequestDto> tests)
        {
            foreach (var test in tests)
            {
                if (Guid.TryParse(test.Test_Code, out var code) == false)
                    continue;

                var targets = _context.Tests.Where(t => t.TestCode == code).ToList();
                if (targets.IsNullOrEmpty())
                    continue;

                var include = ParseIds(test.Included_Test_Item_Ids);
                var exclude = ParseIds(test.Excluded_Test_Item_Ids);

                var firstTatget = targets.First();

                foreach (var addId in include)
                {
                    _context.Tests.Add(new TestRecord
                    {
                        Id = _context.NextTestId(),
                        TestCode = firstTatget.TestCode,
                        ReceptionId = firstTatget.ReceptionId,
                        TestName = firstTatget.TestName,
                        Status = test.Status,
                        TestItemId = addId
                    });
                }

                targets.RemoveAll(i => exclude.Contains(i.Id));

                foreach (var target in targets)
                {
                    target.Status = test.Status;
                    target.TestName = string.IsNullOrWhiteSpace(test.Test_Name) ? target.TestName : test.Test_Name;
                }
            }

            return Task.CompletedTask;
        }

        public Task DeleteTestsAsync(IEnumerable<string> codes)
        {
            var guidCodes = codes
                .Select(code => Guid.TryParse(code, out var parsed) ? parsed : (Guid?)null)
                .Where(g => g.HasValue)
                .Select(g => g.Value)
                .ToArray();

            var testIds = _context.Tests.Where(t => guidCodes.Contains(t.TestCode)).Select(t => t.Id).ToArray();

            _context.Tests.RemoveAll(t => guidCodes.Contains(t.TestCode));
            _context.TestResults.RemoveAll(tr => testIds.Contains(tr.TestId));

            return Task.CompletedTask;
        }

        private static IEnumerable<long> ParseIds(string ids)
        {
            if (string.IsNullOrWhiteSpace(ids))
                return Enumerable.Empty<long>();

            return ids.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(id =>
                {
                    long.TryParse(id, out var value);
                    return value;
                });
        }

        private TestDetailDto CreateTestDetailDto(TestRecord test, ReceptionRecord reception, PatientResponseDto patient, TestItemResponseDto item, TestResultRecord result)
        {
            var equipment = result?.EquipmentId.HasValue == true ? _context.Equipments.FirstOrDefault(e => e.Id == result.EquipmentId.Value) : null;
            var tester = result?.TesterId.HasValue == true ? _context.Testers.FirstOrDefault(t => t.Id == result.TesterId.Value) : null;

            return new TestDetailDto
            {
                Id = test.Id,
                Status = test.Status,
                TestItem_Id = item?.Id,
                Test_Name = test.TestName,
                Test_Code = test.TestCode,
                Name = item?.Name,
                Reference_Max_Value = item?.Reference_Max_Value,
                Reference_Min_Value = item?.Reference_Min_Value,
                TestResult_Id = result?.Id,
                Disison = result?.Decision,
                Test_Dt = result?.TestDate,
                Judgement_Value = result?.JudgementValue,
                Equipment_Id = equipment?.Id,
                EquipmentCode = equipment?.EquipmentCode,
                EquipmentName = equipment?.Name,
                Tester_Id = tester?.Id,
                TesterName = tester?.Name,
                License_Number = tester?.License_Number,
                Reception_Id = reception?.Id ?? 0,
                Reception_Dt = reception?.ReceptionDate ?? DateTime.MinValue,
                Patient_Id = patient?.Id ?? 0,
                PatientName = patient?.Name
            };
        }
    }

    public class InMemoryTestResultRepository : ITestResultRepository
    {
        private readonly InMemoryRepositoryContext _context;

        public InMemoryTestResultRepository(InMemoryRepositoryContext context)
        {
            _context = context;
        }

        public Task AddTestResultsAsync(IEnumerable<TestResultRequestDto> results)
        {
            foreach (var item in results)
            {
                var existing = _context.TestResults.FirstOrDefault(r => r.Id == item.Id);
                if (existing != null)
                {
                    Update(existing, item);
                    continue;
                }

                _context.TestResults.Add(new TestResultRecord
                {
                    Id = _context.NextTestResultId(),
                    TestId = item.TestId,
                    Decision = item.Desison,
                    JudgementValue = item.JudgementValue,
                    EquipmentId = item.EquipmentId,
                    TesterId = item.TesterId,
                    TestDate = item.TestDt
                });
            }

            return Task.CompletedTask;
        }

        public Task ModifyTestResultsAsync(IEnumerable<TestResultRequestDto> results)
        {
            foreach (var item in results)
            {
                var existing = _context.TestResults.FirstOrDefault(r => r.Id == item.Id);
                if (existing != null)
                {
                    Update(existing, item);
                }
                else
                {
                    _context.TestResults.Add(new TestResultRecord
                    {
                        Id = _context.NextTestResultId(),
                        TestId = item.TestId,
                        Decision = item.Desison,
                        JudgementValue = item.JudgementValue,
                        EquipmentId = item.EquipmentId,
                        TesterId = item.TesterId,
                        TestDate = item.TestDt
                    });
                }
            }

            return Task.CompletedTask;
        }

        private static void Update(TestResultRecord target, TestResultRequestDto dto)
        {
            target.Decision = dto.Desison;
            target.JudgementValue = dto.JudgementValue;
            target.EquipmentId = dto.EquipmentId;
            target.TesterId = dto.TesterId;
            target.TestDate = dto.TestDt;
        }
    }
}
