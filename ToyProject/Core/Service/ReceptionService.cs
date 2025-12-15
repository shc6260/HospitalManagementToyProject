using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using ToyProject.Core.Repositories;
using ToyProject.Model;
using ToyProject.Model.Dto;

namespace ToyProject.Core.Service
{
    public class ReceptionService
    {
        public ReceptionService(ReceptionRepository receptionRepository, TestRepository testRepository, PatientRepository patientRepository)
        {
            _receptionRepository = receptionRepository;
            _testRepository = testRepository;
            _patientRepository = patientRepository;
        }

        private ReceptionRepository _receptionRepository;
        private TestRepository _testRepository;
        private PatientRepository _patientRepository;


        public Task<IEnumerable<ReceptionWithPatientSimpleResponse>> GetRecepionWithPatientInfo(DateRange dateRange)
        {
            return Task.Run(async () =>
            {
                var result = await _receptionRepository.FindRecepionWithPatientInfo(dateRange.StartDate, dateRange.EndDate);
                return result.Select(ReceptionWithPatientSimpleResponse.From);
            });
        }

        public Task<Reception> FindReceptionById(long id)
        {
            return Task.Run(async () =>
            {
                var result = await _receptionRepository.FindReceptionWithTests(id);
                return Reception.From(result);
            });
        }

        public Task AddNewPatientReception(Patient patient, Reception reception)
        {
            return Task.Run(async () =>
            {
                using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    var patient_id = await _patientRepository.AddPatientsAsync(patient.ToAddRequestDto());

                    var saveReception = reception.WithPatientId(patient_id);
                    await _receptionRepository.AddReception(saveReception.ToAddRequestDto(), saveReception.GetTestAddRequestDtos());

                    scope.Complete();
                }
            });
        }

        public Task SaveReception(Reception data, Reception origin)
        {
            return Task.Run(async () =>
            {
                if (origin?.Id == null)
                {
                    await _receptionRepository.AddReception(data.ToAddRequestDto(), data.GetTestAddRequestDtos());
                    return;
                }

                await ModlfyReceptions(data, origin);

            });
        }

        private async Task ModlfyReceptions(Reception data, Reception origin)
        {
            var currentById = data.Tests
                .Where(t => t.Id.HasValue)
                .ToDictionary(t => t.Id.Value);

            var originById = origin.Tests
                .Where(t => t.Id.HasValue)
                .ToDictionary(t => t.Id.Value);

            var addedTests = data.Tests.Where(t => t.Id == null).ToList();

            var currentCodes = data.Tests.Select(t => t.TestCode).ToArray();
            var deletedCodes = origin.Tests.Where(i => currentCodes.Contains(i.TestCode) == false)
                    .Select(i => i.TestCode)
                    .ToArray();

            var modifiedTests = currentById.Values
                .Where(t => t.IsDirty(originById[t.Id.Value]))
                .ToList();

            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                if (addedTests.Any())
                    await _testRepository.AddTestsAsync(
                        addedTests.Select(t => t.ToAddDtoForReception()),
                        origin.Id.Value
                    );

                if (deletedCodes.Any())
                    await _testRepository.DeleteTestsAsync(deletedCodes);

                if (modifiedTests.Any())
                    await _testRepository.ModifyTestsAsync(
                        modifiedTests.Select(t =>
                        {
                            var old = originById[t.Id.Value];
                            return t.ToModityDto(old.TestItems.Select(i => i.Id.Value));
                        })
                    );

                scope.Complete();
            }
        }

        public Task DeleteReception(long id)
        {
            return Task.Run(async () =>
            {
                await _receptionRepository.DeleteReception(id);
            });
        }

        //public Task SaveReception(Reception data)
        //{
        //    return Task.Run(async () =>
        //    {
        //        // 내부에서 열리는 모든 Connection이 자동으로 같은 트랜잭션에 참여하도록 합니다.
        //        using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
        //        {
        //            var receptionId = await _receptionRepository.AddReception(data.ToAddRequestDto());
        //            foreach (var test in data.Tests.Select(i => i.ToAddDtoWithReceptionId(receptionId)))
        //                await _testRepository.AddTestAsync(test);

        //            scope.Complete();
        //        }
        //    });
        //}
    }
}
