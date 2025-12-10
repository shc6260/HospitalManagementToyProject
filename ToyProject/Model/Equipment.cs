using ToyProject.Model.Dto;

namespace ToyProject.Model
{
    public class Equipment
    {
        public Equipment(long? id, string equipmentCode, string name, bool enabled)
        {
            Id = id;
            EquipmentCode = equipmentCode;
            Name = name;
            Enabled = enabled;
        }

        public long? Id { get; }

        public string EquipmentCode { get; }

        public string Name { get; }

        public bool Enabled { get; }


        public static Equipment From(EquipmentResponseDto dto)
        {
            return new Equipment
            (
                id: dto.Id,
                equipmentCode: dto.EquipmentCode,
                name: dto.Name,
                enabled: dto.Enabled
            );
        }

        public EquipmentRequestDto ToRequestDto()
        {
            return new EquipmentRequestDto()
            {
                Id = Id.Value,
                EquipmentCode = EquipmentCode,
                Name = Name,
                Enabled = Enabled
            };
        }
        public EquipmentAddRequestDto ToAddRequestDto()
        {
            return new EquipmentAddRequestDto()
            {
                Name = Name,
                EquipmentCode = EquipmentCode
            };
        }
    }
}
