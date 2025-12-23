using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyProject.Core.Class;
using ToyProject.Core.Repositories;
using ToyProject.Model;
using ToyProject.Model.Dto;

namespace ToyProject.Core.Service
{
    public class TestItemService
    {
        private ITestItemRepository _testItemRepository;

        public TestItemService(ITestItemRepository testItemRepository)
        {
            _testItemRepository = testItemRepository;
            _testItemListCache = new SimpleCache<IEnumerable<TestItem>>(args => _testItemRepository.HasChanged(args), () => GetCacheAllTestItemAsync());

        }

        private SimpleCache<IEnumerable<TestItem>> _testItemListCache;

        public async Task<IEnumerable<TestItem>> GetAllTestItemAsync(bool? isEnabled = null)
        {
            var result = await _testItemListCache.GetAsync();
            return isEnabled == null ? result : result.Where(i => i.IsEnabled == isEnabled).ToList();
        }


        public async Task<IEnumerable<TestItem>> GetCacheAllTestItemAsync()
        {
            var result = await _testItemRepository.FindAll();
            return result.Select(TestItem.From);
        }

        public Task SaveTestItemAsync(TestItem data)
        {
            if (data == null)
                return Task.CompletedTask;

            if (data.Id == null)
                return _testItemRepository.AddTestItem(data.ToAddRequestDto());

            return _testItemRepository.ModifyTestItem(data.ToRequestDto());
        }

        public Task DeleteTestItemAsync(long id)
        {
            //todo 삭제 가능여부 확인 로직

            return _testItemRepository.DeleteTestItem(id);
        }

        public Task SetEnabledTestItemAsync(long id, bool enabled)
        {
            return _testItemRepository.ModifyTestItem
            (
                new TestItemRequestDto()
                {
                    Id = id,
                    Enabled = enabled
                }
            );
        }
    }
}
