using ToyProject.Model.Type;

namespace ToyProject.Model.Dto
{
    public class TestAddRequestDto
    {
        public long Reception_Id { get; set; }

        public string TestName { get; set; }

        public string TestItemIds { get; set; }
    }

    public class TestModifyRequestDto
    {
        public string Test_Code { get; set; }

        public StatusType Status { get; set; }

        public string Included_Test_Item_Ids { get; set; }

        public string Excluded_Test_Item_Ids { get; set; }

        public string Test_Name { get; set; }
    }
}
