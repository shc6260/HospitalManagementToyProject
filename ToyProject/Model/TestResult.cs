using System;
using System.Data;
using ToyProject.Core.Helper;
using ToyProject.Model.Dto;

namespace ToyProject.Model
{
    public class TestResult
    {
        public TestResult(long? id, long testId, string decision, DateTime? testDate, string judgementValue, long? equipmentId,
            string equipmentCode, string equipmentName, long? testerId, string testerName, string licenseNumber)
        {
            Id = id;
            TestId = testId;
            Decision = decision;
            TestDate = testDate;
            JudgementValue = judgementValue;
            EquipmentId = equipmentId;
            EquipmentCode = equipmentCode;
            EquipmentName = equipmentName;
            TesterId = testerId;
            TesterName = testerName;
            LicenseNumber = licenseNumber;
        }

        public long? Id { get; }

        public long TestId { get; }

        public string Decision { get; }
        public DateTime? TestDate { get; }
        public string JudgementValue { get; }

        public long? EquipmentId { get; }
        public string EquipmentCode { get; }
        public string EquipmentName { get; }

        public long? TesterId { get; }
        public string TesterName { get; }
        public string LicenseNumber { get; }

        public static TestResult From(TestDetailDto dto)
        {
            return new TestResult(
                id: dto.TestResult_Id,
                testId: dto.Id,
                decision: dto.Disison,
                testDate: dto.Test_Dt,
                judgementValue: dto.Judgement_Value,
                equipmentId: dto.Equipment_Id,
                equipmentCode: dto.EquipmentCode,
                equipmentName: dto.EquipmentName,
                testerId: dto.Tester_Id,
                testerName: dto.TesterName,
                licenseNumber: dto.License_Number);
        }

        public static TestResult FromDataRow(DataRow row, DataRowVersion version)
        {
            if (row == null)
                return null;

            return new TestResult(
                id: row.GetNullableLong(nameof(Id), version),
                testId: row.GetLong(nameof(TestId), version),
                decision: row.GetString(nameof(Decision), version),
                testDate: row.GetNullableDateTime(nameof(TestDate), version),
                judgementValue: row.GetString(nameof(JudgementValue), version),
                equipmentId: row.GetNullableLong(nameof(EquipmentId), version),
                equipmentCode: row.GetString(nameof(EquipmentCode), version),
                equipmentName: row.GetString(nameof(EquipmentName), version),
                testerId: row.GetNullableLong(nameof(TesterId), version),
                testerName: row.GetString(nameof(TesterName), version),
                licenseNumber: row.GetString(nameof(LicenseNumber), version));
        }

        public TestResultRequestDto ToDto()
        {
            return new TestResultRequestDto
            {
                Id = Id,
                TestId = TestId,
                Desison = Decision,
                JudgementValue = JudgementValue,
                EquipmentId = EquipmentId,
                TesterId = TesterId,
                TestDt = TestDate
            };
        }
    }
}
