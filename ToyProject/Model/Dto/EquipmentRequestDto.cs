namespace ToyProject.Model.Dto
{
    public class EquipmentRequestDto
    {
        public long Id { get; set; }

        public string EquipmentCode { get; set; }

        public string Name { get; set; }

        public bool Enabled { get; set; }
    }

    public class EquipmentAddRequestDto
    {
        public string EquipmentCode { get; set; }

        public string Name { get; set; }
    }
}
