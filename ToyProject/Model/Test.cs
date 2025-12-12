using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        public static Test From(long? id, string testCode, string testName, StatusType? status, IEnumerable<long> testItemIds)
        {
            return new Test
            (
                id,
                testCode,
                testName,
                status,
                testItemIds.Select(TestItem.FromId)
            );
        }

        public TestAddRequestDto ToAddDto()
        {
            return new TestAddRequestDto()
            {
                Test_Name = TestName,
                TestItem_Ids = TestItems.Select(i => i.Id.Value)
            };
        }
    }
}
}
