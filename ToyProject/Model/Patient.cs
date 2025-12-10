namespace ToyProject.Model
{
    public class Patient
    {
        #region Constructors

        public Patient(long? id, string chartNumber, string name, string socialSecurityNumber, string gender, string phoneNumber, string address, string memo, string qualificationInfo)
        {
            Id = id;
            ChartNumber = chartNumber;
            Name = name;
            SocialSecurityNumber = socialSecurityNumber;
            Gender = gender;
            PhoneNumber = phoneNumber;
            Address = address;
            Memo = memo;
            QualificationInfo = qualificationInfo;
        }

        #endregion


        #region Properties

        public long? Id { get; }

        public string ChartNumber { get; }

        public string Name { get; }

        public string SocialSecurityNumber { get; }

        public string Gender { get; }

        public string PhoneNumber { get; }

        public string Address { get; }

        public string Memo { get; }

        public string QualificationInfo { get; }

        #endregion


        #region Helpers

        public static Patient From(PatientResponseDto patientDto)
        {
            return new Patient
          (
              id: patientDto.Id,
              chartNumber: patientDto.ChartNumber,
              name: patientDto.Name,
              socialSecurityNumber: patientDto.Social_Security_Number,
              gender: patientDto.Gender,
              phoneNumber: patientDto.PhoneNumber,
              address: patientDto.Address,
              memo: patientDto.Memo,
              qualificationInfo: patientDto.Qualification_Info
          );
        }

        public static Patient From(long? id, string chartNumber, string name, string socialSecurityNumber, string gender, string phoneNumber, string address, string memo, string qualificationInfo)
        {
            return new Patient
            (
                id: id,
                chartNumber: chartNumber,
                name: name,
                socialSecurityNumber: socialSecurityNumber,
                gender: gender,
                phoneNumber: phoneNumber,
                address: address,
                memo: memo,
                qualificationInfo: qualificationInfo
            );
        }

        public Patient WithId(long id)
        {
            return new Patient
            (
                id: id,
                chartNumber: ChartNumber,
                name: Name,
                socialSecurityNumber: SocialSecurityNumber,
                gender: Gender,
                phoneNumber: PhoneNumber,
                address: Address,
                memo: Memo,
                qualificationInfo: QualificationInfo
            );
        }

        public PatientRequestDto ToRequestDto()
        {
            return new PatientRequestDto()
            {
                Id = Id,
                Name = Name,
                Address = Address,
                ChartNumber = ChartNumber,
                Memo = Memo,
                PhoneNumber = PhoneNumber,
                Social_Security_Number = SocialSecurityNumber,
                Qualification_Info = QualificationInfo
            };
        }

        public PatientAddRequestDto ToAddRequestDto()
        {
            return new PatientAddRequestDto()
            {
                Name = Name,
                Address = Address,
                ChartNumber = ChartNumber,
                Memo = Memo,
                PhoneNumber = PhoneNumber,
                Social_Security_Number = SocialSecurityNumber,
                Qualification_Info = QualificationInfo
            };
        }

        #endregion
    }
}
