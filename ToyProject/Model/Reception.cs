using System;
using System.Collections.Generic;
using System.Linq;
using ToyProject.Model.Dto;

namespace ToyProject.Model
{
    public class Reception
    {
        public Reception(long? id, long? patientId, bool isEmergency, bool isNight, string memo, string insuredInfo, string specificalCode, string insuranceInfo, string checkupTargetInfo, DateTime receptionDate, IEnumerable<TestItem> testItems)
        {
            Id = id;
            PatientId = patientId;
            IsEmergency = isEmergency;
            IsNight = isNight;
            Memo = memo;
            InsuredInfo = insuredInfo;
            SpecificalCode = specificalCode;
            InsuranceInfo = insuranceInfo;
            CheckupTargetInfo = checkupTargetInfo;
            ReceptionDate = receptionDate;
            TestItems = testItems;
        }


        public long? Id { get; }

        public long? PatientId { get; }

        public bool IsEmergency { get; }

        public bool IsNight { get; }

        public string Memo { get; }

        public string InsuredInfo { get; }

        public string SpecificalCode { get; }

        public string InsuranceInfo { get; }

        public string CheckupTargetInfo { get; }

        public DateTime ReceptionDate { get; }

        public IEnumerable<TestItem> TestItems { get; }


        public static Reception From(ReceptionResponseDto dto)
        {
            return new Reception
            (
                id: dto.Id,
                patientId: dto.Patient_Id,
                isEmergency: dto.Emergency,
                isNight: dto.Night,
                memo: dto.Memo,
                insuredInfo: dto.Insured_info,
                specificalCode: dto.Specifical_code,
                insuranceInfo: dto.Insurance_info,
                checkupTargetInfo: dto.Checkup_target_info,
                receptionDate: dto.Reception_dt,
                Enumerable.Empty<TestItem>()
            ); ;
        }

        public Reception WithPatientId(long patientId)
        {
            return new Reception
            (
                id: Id,
                patientId: patientId,
                isEmergency: IsEmergency,
                isNight: IsNight,
                memo: Memo,
                insuredInfo: InsuredInfo,
                specificalCode: SpecificalCode,
                insuranceInfo: InsuranceInfo,
                checkupTargetInfo: CheckupTargetInfo,
                receptionDate: ReceptionDate,
                testItems: TestItems
            );
        }

        public ReceptionAddRequestDto ToAddRequestDto()
        {
            return new ReceptionAddRequestDto()
            {
                Patient_Id = PatientId.Value,
                Checkup_target_info = CheckupTargetInfo,
                Emergency = IsEmergency,
                Night = IsNight,
                Insurance_info = InsuranceInfo,
                Insured_info = InsuredInfo,
                Memo = Memo,
                Reception_dt = ReceptionDate,
                Specifical_code = SpecificalCode,
                TestItem_Ids = TestItems?.Select(i => i.Id.Value)
            };
        }
    }
}
