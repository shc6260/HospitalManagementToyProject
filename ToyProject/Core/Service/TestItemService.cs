using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyProject.Core.Repositories;
using ToyProject.Model;
using ToyProject.Model.Dto;

namespace ToyProject.Core.Service
{
    public class TestItemService
    {
        private TestItemRepository _testItemRepository;

        public TestItemService(TestItemRepository testItemRepository)
        {
            _testItemRepository = testItemRepository;
        }

        public Task<IEnumerable<TestItem>> GetAllTestItemAsync()
        {
            return Task.Run(async () =>
            {
                var result = await _testItemRepository.FindAll();
                return result.Select(TestItem.From);
            });
        }

        public Task UpdateTestItemAsync(TestItem data)
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
