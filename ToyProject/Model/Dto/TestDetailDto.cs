using System;
using System.Collections.Generic;

namespace ToyProject.Model.Dto
{
    public class TestDetailDto
    {
        // Test
        public long Id { get; set; }
        public string Status { get; set; }
        public long? TestItem_Id { get; set; }
        public string Test_Name { get; set; }
        public Guid? Test_Code { get; set; }

        // TestItem
        public string Name { get; set; }
        public decimal? Reference_Max_Value { get; set; }
        public decimal? Reference_Min_Value { get; set; }

        // TestResult
        public long? TestResult_Id { get; set; }
        public string Disison { get; set; }
        public DateTime? Test_Dt { get; set; }
        public string Judgement_Value { get; set; }

        // Equipment
        public long? Equipment_Id { get; set; }
        public string EquipmentCode { get; set; }
        public string EquipmentName { get; set; }

        // Tester
        public long? Tester_Id { get; set; }
        public string TesterName { get; set; }
        public string License_Number { get; set; }

        // Reception
        public long Reception_Id { get; set; }
        public DateTime Reception_Dt { get; set; }

        // Patient
        public long Patient_Id { get; set; }
        public string PatientName { get; set; }
    }
}
