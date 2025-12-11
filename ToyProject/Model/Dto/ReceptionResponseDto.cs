using System;

namespace ToyProject.Model.Dto
{
    public class ReceptionResponseDto
    {
        public long Id { get; set; }

        public long? Patient_Id { get; set; }

        public bool Emergency { get; set; }

        public bool Night { get; set; }

        public string Memo { get; set; }

        public string Insured_info { get; set; }

        public string Specifical_code { get; set; }

        public string Insurance_info { get; set; }

        public string Checkup_target_info { get; set; }

        public DateTime Reception_dt { get; set; }
    }

    public class ReceptionWithPatientSimpleResponseDto
    {
        public long Id { get; set; }

        public string Reception_dt { get; set; }

        public string PatientName { get; set; }

        public string Chartnumber { get; set; }
    }
}
