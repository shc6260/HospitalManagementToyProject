using System;
using System.Collections.Generic;
using System.Linq;
using ToyProject.Model.Dto;

namespace ToyProject.Model
{
    public class Reception
    {
        public Reception(long? id, long? patientId, bool isEmergency, bool isNight, string memo, string insuredInfo, string specificalCode, string insuranceInfo, string checkupTargetInfo, DateTime receptionDate, IEnumerable<Test> tests)
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
            Tests = tests;
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

        public IEnumerable<Test> Tests { get; }


        public static Reception From(IEnumerable<ReceptionResponseDto> dtos)
        {
            var receptionGroup = dtos
               .GroupBy(i => i.Id)
               .FirstOrDefault();

            if (receptionGroup == null)
                return null;

            var dto = receptionGroup.First();

            var tests = receptionGroup
                .Where(x => x.Test_Id.HasValue)
                .GroupBy(x => x.Test_Id)
                .Select(g =>
                {
                    var testDto = g.First();

                    return Test.From(
                        testDto.Test_Id,
                        testDto.Test_Code,
                        testDto.Test_Name,
                        testDto.Status,
                        g.Select(i => i.TestItem_id)
                    );
                })
                .ToArray();

            return new Reception(
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
               tests: tests
            );
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
                tests: Tests
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
                Specifical_code = SpecificalCode
            };
        }
    }
}
