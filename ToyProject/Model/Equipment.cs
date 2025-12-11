using ToyProject.Model.Dto;

namespace ToyProject.Model
{
    public class Equipment
    {
        public Equipment(long? id, string equipmentCode, string name, bool isEnabled)
        {
            Id = id;
            EquipmentCode = equipmentCode;
            Name = name;
            IsEnabled = isEnabled;
        }

        public long? Id { get; }

        public string EquipmentCode { get; }

        public string Name { get; }

        public bool IsEnabled { get; }


        public static Equipment From(EquipmentResponseDto dto)
        {
            return new Equipment
            (
                id: dto.Id,
                equipmentCode: dto.EquipmentCode,
                name: dto.Name,
                isEnabled: dto.Enabled
            );
        }

        public EquipmentRequestDto ToRequestDto()
        {
            return new EquipmentRequestDto()
            {
                Id = Id.Value,
                EquipmentCode = EquipmentCode,
                Name = Name,
                Enabled = IsEnabled
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
