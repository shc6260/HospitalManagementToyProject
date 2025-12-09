namespace ToyProject.Model
{
    public class Tester
    {
        public Tester(long? id, string licenseNumber, string name, string officeInfo, bool enabled)
        {
            Id = id;
            LicenseNumber = licenseNumber;
            Name = name;
            OfficeInfo = officeInfo;
            Enabled = enabled;
        }

        public long? Id { get; }

        public string LicenseNumber { get; }

        public string Name { get; }

        public string OfficeInfo { get; }

        public bool Enabled { get; }


        public static Tester From(TesterResponseDto dto)
        {
            return new Tester
            (
                id: dto.Id,
                licenseNumber: dto.License_Number,
                name: dto.Name,
                officeInfo: dto.Office_Info,
                enabled: dto.Enabled
            );
        }

        public TesterRequestDto ToRequestDto()
        {
            return new TesterRequestDto()
            {
                Id = Id,
                License_Number = LicenseNumber,
                Name = Name,
                Enabled = Enabled,
                Office_Info = OfficeInfo
            };
        }

        public TesterAddRequestDto ToAddRequestDto()
        {
            return new TesterAddRequestDto()
            {
                License_Number = LicenseNumber,
                Name = Name,
                Office_Info = OfficeInfo
            };
        }
    }
}
