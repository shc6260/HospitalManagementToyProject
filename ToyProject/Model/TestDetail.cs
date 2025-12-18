using System;
using System.Collections.Generic;
using System.Linq;
using ToyProject.Core.Helper;
using ToyProject.Model.Dto;
using ToyProject.Model.Type;

namespace ToyProject.Model
{
    /// <summary>
    /// Immutable view model for detailed test information.
    /// </summary>
    public class TestDetail
    {
        public TestDetail(long id, StatusType? status, long? testItemId, string testName, Guid? testCode, string testItemName, decimal? referenceMaxValue,
            decimal? referenceMinValue, long receptionId, DateTime receptionDate, long patientId, string patientName, IEnumerable<TestResult> results)
        {
            Id = id;
            Status = status;
            TestItemId = testItemId;
            TestName = testName;
            TestCode = testCode;
            TestItemName = testItemName;
            ReferenceMaxValue = referenceMaxValue;
            ReferenceMinValue = referenceMinValue;
            ReceptionId = receptionId;
            ReceptionDate = receptionDate;
            PatientId = patientId;
            PatientName = patientName;
            Results = results;
        }



        // Core identifiers and state
        public long Id { get; }
        public StatusType? Status { get; }
        public long? TestItemId { get; }
        public string TestName { get; }
        public Guid? TestCode { get; }
        public string TestItemName { get; }
        public decimal? ReferenceMaxValue { get; }
        public decimal? ReferenceMinValue { get; }

        public string DisplayReferenceValue => $"{ReferenceMinValue} ~ {ReferenceMaxValue}";

        // Reception / patient
        public long ReceptionId { get; }
        public DateTime ReceptionDate { get; }
        public long PatientId { get; }
        public string PatientName { get; }

        public IEnumerable<TestResult> Results { get; }


        public static IEnumerable<TestDetail> FromDtos(IEnumerable<TestDetailDto> dtos)
        {
            if (dtos.IsNullOrEmpty())
                yield break;

            var groups = dtos.GroupBy(dto => dto.Id);

            foreach (var group in groups)
            {
                var dto = group.First();

                yield return new TestDetail(
                    id: dto.Id,
                    status: dto.Status ?? StatusType.Reception,
                    testItemId: dto.TestItem_Id,
                    testName: dto.Test_Name,
                    testCode: dto.Test_Code,
                    testItemName: dto.Name,
                    referenceMaxValue: dto.Reference_Max_Value,
                    referenceMinValue: dto.Reference_Min_Value,
                    receptionId: dto.Reception_Id,
                    receptionDate: dto.Reception_Dt,
                    patientId: dto.Patient_Id,
                    patientName: dto.PatientName,
                    results: group.IsNullOrEmpty() ? Enumerable.Empty<TestResult>() : group.Select(g => TestResult.From(g))
                );
            }
        }
    }
}
