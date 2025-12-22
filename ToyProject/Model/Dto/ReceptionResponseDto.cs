using System;
using ToyProject.Model.Type;

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

        public long? Test_Id { get; set; }

        public Guid Test_Code { get; set; }

        public string Test_Name { get; set; }

        public StatusType Status { get; set; }

        public long TestItem_id { get; set; }

        public string TestItem_Name { get; set; }
    }

    public class ReceptionWithPatientSimpleResponseDto
    {
        public long Id { get; set; }

        public DateTime Reception_dt { get; set; }

        public string PatientName { get; set; }

        public string Chartnumber { get; set; }
    }
}
