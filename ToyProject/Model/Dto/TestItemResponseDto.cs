namespace ToyProject.Model.Dto
{
    public class TestItemResponseDto
    {
        public long Id { get; set; }

        public string TestItemCode { get; set; }

        public string Name { get; set; }

        public int Reference_Min_Value { get; set; }

        public int Reference_Max_Value { get; set; }

        public bool Enabled { get; set; }
    }
}
