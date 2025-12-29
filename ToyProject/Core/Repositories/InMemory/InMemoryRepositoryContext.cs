using System;
using System.Collections.Generic;
using System.Linq;
using ToyProject.Model;
using ToyProject.Model.Dto;
using ToyProject.Model.Type;

namespace ToyProject.Core.Repositories.InMemory
{
    public class InMemoryRepositoryContext
    {
        public InMemoryRepositoryContext()
        {
            Seed();
        }

        public List<PatientResponseDto> Patients { get; } = new List<PatientResponseDto>();
        public List<TesterResponseDto> Testers { get; } = new List<TesterResponseDto>();
        public List<TestItemResponseDto> TestItems { get; } = new List<TestItemResponseDto>();
        public List<EquipmentResponseDto> Equipments { get; } = new List<EquipmentResponseDto>();
        public List<ReceptionRecord> Receptions { get; } = new List<ReceptionRecord>();
        public List<TestRecord> Tests { get; } = new List<TestRecord>();
        public List<TestResultRecord> TestResults { get; } = new List<TestResultRecord>();

        private long _patientSeq = 1;
        private long _testerSeq = 1;
        private long _testItemSeq = 1;
        private long _equipmentSeq = 1;
        private long _receptionSeq = 1;
        private long _testSeq = 1;
        private long _testResultSeq = 1;

        public long NextPatientId() => _patientSeq++;
        public long NextTesterId() => _testerSeq++;
        public long NextTestItemId() => _testItemSeq++;
        public long NextEquipmentId() => _equipmentSeq++;
        public long NextReceptionId() => _receptionSeq++;
        public long NextTestId() => _testSeq++;
        public long NextTestResultId() => _testResultSeq++;

        private void Seed()
        {
            if (Patients.Any())
                return;

            // 기본 검사 항목
            var cbc = AddTestItem("TI-001", "혈액 일반", 10, 20, true);
            var lft = AddTestItem("TI-002", "간 기능", 5, 15, true);
            var pcr = AddTestItem("TI-003", "PCR", 0, 1, true);

            // 장비
            var eq1 = AddEquipment("EQ-001", "혈액 분석기", true);
            var eq2 = AddEquipment("EQ-002", "PCR 장비", true);

            // 검사자
            var tester1 = AddTester("L-001", "김검사", "내과", true);
            var tester2 = AddTester("L-002", "이다른", "검사실", true);

            // 환자
            var patient1 = AddPatient("P0001", "홍길동", "900101-1234567", "M", "010-1111-2222", "서울시", "특이사항 없음", "의료급여1종");
            var patient2 = AddPatient("P0002", "김유저", "920202-2345678", "F", "010-3333-4444", "부산시", "알레르기 있음", "건강보험");

            // 접수 + 검사 + 결과
            var reception1 = AddReception(patient1.Id, DateTime.Now.AddHours(-3), false, false, "메모1", "보험1", "특별1", "건강보험", "검진대상1");
            var reception2 = AddReception(patient2.Id, DateTime.Now.AddDays(-1), false, false, "메모2", "보험2", "특별2", "건강보험", "검진대상2");

            var testA = AddTest(reception1.Id, "혈액 검사", StatusType.Progress, new[] { cbc.Id, lft.Id }).ToArray();
            //var testB = AddTest(reception1.Id, "PCR 검사", StatusType.Reception, new[] { pcr.Id });
            //var testC = AddTest(reception2.Id, "기본 검사", StatusType.Complete, new[] { cbc.Id });

            AddTestResult(testA.First().Id, "정상", DateTime.Now.AddHours(-1), "13.2", eq1.Id, tester1.Id);
            //AddTestResult(testC.First().Id, "재검 요망", DateTime.Now.AddDays(-1), "0.8", eq2.Id, tester2.Id);
        }

        private PatientResponseDto AddPatient(string chartNumber, string name, string ssn, string gender, string phone, string address, string memo, string qualification)
        {
            var patient = new PatientResponseDto
            {
                Id = NextPatientId(),
                ChartNumber = chartNumber,
                Name = name,
                Social_Security_Number = ssn,
                Gender = gender,
                PhoneNumber = phone,
                Address = address,
                Memo = memo,
                Qualification_Info = qualification
            };

            Patients.Add(patient);
            return patient;
        }

        private TesterResponseDto AddTester(string license, string name, string office, bool enabled)
        {
            var tester = new TesterResponseDto
            {
                Id = NextTesterId(),
                License_Number = license,
                Name = name,
                Office_Info = office,
                Enabled = enabled
            };

            Testers.Add(tester);
            return tester;
        }

        private TestItemResponseDto AddTestItem(string code, string name, int min, int max, bool enabled)
        {
            var item = new TestItemResponseDto
            {
                Id = NextTestItemId(),
                TestItemCode = code,
                Name = name,
                Reference_Min_Value = min,
                Reference_Max_Value = max,
                Enabled = enabled
            };

            TestItems.Add(item);
            return item;
        }

        private EquipmentResponseDto AddEquipment(string code, string name, bool enabled)
        {
            var equipment = new EquipmentResponseDto
            {
                Id = NextEquipmentId(),
                EquipmentCode = code,
                Name = name,
                Enabled = enabled
            };

            Equipments.Add(equipment);
            return equipment;
        }

        private ReceptionRecord AddReception(long patientId, DateTime receptionDt, bool emergency, bool night, string memo, string insured, string specific, string insurance, string target)
        {
            var reception = new ReceptionRecord
            {
                Id = NextReceptionId(),
                PatientId = patientId,
                Emergency = emergency,
                Night = night,
                Memo = memo,
                InsuredInfo = insured,
                SpecificalCode = specific,
                InsuranceInfo = insurance,
                CheckupTargetInfo = target,
                ReceptionDate = receptionDt
            };

            Receptions.Add(reception);
            return reception;
        }

        private IEnumerable<TestRecord> AddTest(long receptionId, string name, StatusType status, IEnumerable<long> testItemIds)
        {
            var code = Guid.NewGuid();

            foreach (var id in testItemIds?.ToArray() ?? Enumerable.Empty<long>())
            {
                var test = new TestRecord
                {
                    Id = NextTestId(),
                    TestCode = code,
                    ReceptionId = receptionId,
                    TestName = name,
                    Status = status,
                    TestItemId = id
                };

                Tests.Add(test);

                yield return test;
            }
        }

        private TestResultRecord AddTestResult(long testId, string decision, DateTime? testDt, string judgement, long? equipmentId, long? testerId)
        {
            var result = new TestResultRecord
            {
                Id = NextTestResultId(),
                TestId = testId,
                Decision = decision,
                TestDate = testDt,
                JudgementValue = judgement,
                EquipmentId = equipmentId,
                TesterId = testerId
            };

            TestResults.Add(result);
            return result;
        }
    }

    public class ReceptionRecord
    {
        public long Id { get; set; }
        public long PatientId { get; set; }
        public bool Emergency { get; set; }
        public bool Night { get; set; }
        public string Memo { get; set; }
        public string InsuredInfo { get; set; }
        public string SpecificalCode { get; set; }
        public string InsuranceInfo { get; set; }
        public string CheckupTargetInfo { get; set; }
        public DateTime ReceptionDate { get; set; }
    }

    public class TestRecord
    {
        public long Id { get; set; }
        public Guid TestCode { get; set; }
        public string TestName { get; set; }
        public StatusType Status { get; set; }
        public long ReceptionId { get; set; }
        public long TestItemId { get; set; }
    }

    public class TestResultRecord
    {
        public long Id { get; set; }
        public long TestId { get; set; }
        public string Decision { get; set; }
        public DateTime? TestDate { get; set; }
        public string JudgementValue { get; set; }
        public long? EquipmentId { get; set; }
        public long? TesterId { get; set; }
    }
}
