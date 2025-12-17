using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using ToyProject.Core.Helper;
using ToyProject.Core.Repositories;
using ToyProject.Model;
using ToyProject.Model.Type;

namespace ToyProject.Core.Service
{
    public class TestService
    {
        public TestService(TestRepository testRepository, TestResultRepository testResultRepository)
        {
            _testRepository = testRepository;
            _testResultRepository = testResultRepository;
        }

        private readonly TestRepository _testRepository;
        private readonly TestResultRepository _testResultRepository;

        public async Task<IEnumerable<TestDetail>> GetTestsAsync(StatusType status)
        {
            var dtoList = await _testRepository.GetTestsAsync(status);
            return dtoList.IsNullOrEmpty() ? Enumerable.Empty<TestDetail>() : TestDetail.FromDtos(dtoList);
        }

        public async Task SaveChangesAsync(IEnumerable<DataTableChange<TestResult>> changes)
        {
            if (changes.IsNullOrEmpty())
                return;

            var changeGroup = changes.GroupBy(i => i.ChangeType).ToDictionary(k => k.Key, v => v.Select(i => i.Data));

            using (var scope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                if (changeGroup.TryGetValue(DataRowState.Added, out var adds))
                    await InsertAsync(adds);

                if (changeGroup.TryGetValue(DataRowState.Modified, out var modifieds))
                    await UpdateAsync(modifieds);

                scope.Complete();
            }
        }

        private Task InsertAsync(IEnumerable<TestResult> test)
        {
            return _testResultRepository.AddTestResultsAsync(test.Select(i => i.ToDto()).ToArray());
        }

        private Task UpdateAsync(IEnumerable<TestResult> test)
        {
            return _testResultRepository.ModifyTestResultsAsync(test.Select(i => i.ToDto()).ToArray());
        }
    }
}
