using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyProject.Core.Repositories;
using ToyProject.Model;

namespace ToyProject.Core.Service
{
    public class TestService
    {
        public TestService(TestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        private readonly TestRepository _testRepository;

        public Task<IEnumerable<Test>> GetTestsAsync()
        {
            // TODO: 저장소 조회 메서드가 준비되면 실제 데이터 조회 로직으로 교체
            return Task.FromResult<IEnumerable<Test>>(Enumerable.Empty<Test>());
        }

        public Task SaveTestAsync(Test test)
        {
            // TODO: 추가/수정 로직 연결
            return Task.CompletedTask;
        }

        public Task DeleteTestAsync(Test test)
        {
            // TODO: 삭제 로직 연결
            return Task.CompletedTask;
        }

        public Task ToggleStatusAsync(Test test)
        {
            // TODO: 상태 토글 로직 연결
            return Task.CompletedTask;
        }
    }
}
