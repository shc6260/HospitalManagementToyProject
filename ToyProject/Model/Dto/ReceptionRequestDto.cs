using System;
using System.Collections.Generic;

namespace ToyProject.Model.Dto
{
    public class ReceptionModifyRequestDto
    {
        public long Id { get; set; }

        public bool Emergency { get; set; }

        public bool Night { get; set; }

        public string Memo { get; set; }

        public string Insured_info { get; set; }

        public string Specifical_code { get; set; }

        public string Insurance_info { get; set; }

        public string Checkup_target_info { get; set; }

        public DateTime Reception_dt { get; set; }
    }

    public class ReceptionAddRequestDto
    {
        public long Patient_Id { get; set; }

        public bool Emergency { get; set; }

        public bool Night { get; set; }

        public string Memo { get; set; }

        public string Insured_info { get; set; }

        public string Specifical_code { get; set; }

        public string Insurance_info { get; set; }

        public string Checkup_target_info { get; set; }

        public DateTime Reception_dt { get; set; }
    }

    public class ReceptionFindRequestDto
    {
        public DateTime Reception_Start_Dt { get; set; }

        public DateTime Reception_End_Dt { get; set; }
    }
}
