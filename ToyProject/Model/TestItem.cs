using ToyProject.Model.Dto;

namespace ToyProject.Model
{
    public class TestItem
    {
        public TestItem(long? id, string testItemCode, string name, int referenceMinValue, int referenceMaxValue, bool enabled)
        {
            Id = id;
            TestItemCode = testItemCode;
            Name = name;
            ReferenceMinValue = referenceMinValue;
            ReferenceMaxValue = referenceMaxValue;
            Enabled = enabled;
        }

        public long? Id { get; }

        public string TestItemCode { get; }

        public string Name { get; }

        public int ReferenceMinValue { get; }

        public int ReferenceMaxValue { get; }

        public bool Enabled { get; }

        public string DisplayReferenceValue => $"{ReferenceMinValue} ~ {ReferenceMaxValue}";


        public static TestItem From(long? id, string testItemCode, string name, string referenceMinValue, string referenceMaxValue, bool enabled)
        {
            return new TestItem
            (
                id,
                testItemCode,
                name,
                int.TryParse(referenceMinValue, out var minValue) ? minValue : 0,
                int.TryParse(referenceMaxValue, out var maxValue) ? maxValue : 0,
                enabled
            );
        }

        public static TestItem From(TestItemResponseDto dto)
        {
            return new TestItem
            (
                id: dto.Id,
                testItemCode: dto.TestItemCode,
                name: dto.Name,
                referenceMinValue: dto.Reference_Min_Value,
                referenceMaxValue: dto.Reference_Max_Value,
                enabled: dto.Enabled
            );
        }

        public TestItemRequestDto ToRequestDto()
        {
            return new TestItemRequestDto()
            {
                Id = Id.Value,
                Name = Name,
                TestItemCode = TestItemCode,
                Reference_Min_Value = ReferenceMinValue,
                Reference_Max_Value = ReferenceMaxValue,
                Enabled = Enabled
            };
        }

        public TestItemAddRequestDto ToAddRequestDto()
        {
            return new TestItemAddRequestDto()
            {
                Name = Name,
                TestItemCode = TestItemCode,
                Reference_Min_Value = ReferenceMinValue,
                Reference_Max_Value = ReferenceMaxValue
            };
        }
    }
}
