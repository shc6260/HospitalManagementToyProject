using System.Collections.Generic;
using System.Linq;
using ToyProject.Model.Dto;
using ToyProject.Model.Type;

namespace ToyProject.Model
{
    public class Test
    {
        public Test(long? id, string testCode, string testName, StatusType? status, IEnumerable<TestItem> testItems)
        {
            TestCode = testCode;
            TestName = testName;
            Status = status;
            TestItems = testItems;
            Id = id;
        }

        public long? Id { get; }

        public string TestCode { get; }

        public string TestName { get; }

        public StatusType? Status { get; }

        public IEnumerable<TestItem> TestItems { get; }

        public string DisplayTestItem => string.Join(", ", TestItems.Select(i => i.Name));


        public static Test FromAdd(string testName, IEnumerable<TestItem> testItems)
        {
            return new Test
            (
                null,
                null,
                testName,
                null,
                testItems
            );
        }


        public static Test From(long? id, string testCode, string testName, StatusType? status, IEnumerable<TestItem> testItems)
        {
            return new Test
            (
                id: id,
                testCode: testCode,
                testName: testName,
                status: status,
                testItems: testItems
            );
        }

        public TestAddRequestDto ToAddDtoForReception()
        {
            return new TestAddRequestDto()
            {
                TestName = TestName,
                TestItemIds = string.Join(",", TestItems.Select(i => i.Id))
            };
        }

        public TestAddRequestDto ToAddDto(long receptionId)
        {
            return new TestAddRequestDto()
            {
                Reception_Id = receptionId,
                TestName = TestName,
                TestItemIds = string.Join(",", TestItems.Select(i => i.Id))
            };
        }

        public TestModifyRequestDto ToModityDto(IEnumerable<long> oldTestItemIds)
        {
            var include = TestItems.Where(i => oldTestItemIds.Contains(i.Id.Value) == false).Select(i => i.Id).ToArray();
            var exclude = oldTestItemIds.Where(i => TestItems.Select(ti => ti.Id).Contains(i) == false).ToArray();

            return new TestModifyRequestDto()
            {
                Test_Code = TestCode,
                Test_Name = TestName,
                Status = Status ?? StatusType.Reception,
                Included_Test_Item_Ids = string.Join(",", include),
                Excluded_Test_Item_Ids = string.Join(",", exclude)
            };
        }

        public bool IsDirty(Test old)
        {
            if (old == null)
                return false;

            return TestName != old.TestName
                || !old.TestItems.Select(x => x.Id)
                       .SequenceEqual(TestItems.Select(x => x.Id));
        }
    }
}
