using ToyProject.Model.Type;

namespace ToyProject.Model.Dto
{
    public class TestReponseDto
    {
        public long? Id { get; set; }

        public string Test_Code { get; set; }

        public string Test_Name { get; set; }

        public StatusType? Status { get; set; }

        public long TestItem_id { get; set; }
    }
}
