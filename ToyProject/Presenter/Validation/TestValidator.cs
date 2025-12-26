using System.Collections.Generic;
using System.Linq;
using ToyProject.Core.Validation;
using ToyProject.Model;
using ToyProject.Properties;

namespace ToyProject.Presenter.Validation
{
    public static class TestValidator
    {
        public static ValidationResult Validate(string testName, IEnumerable<TestItem> items)
        {
            var result = new ValidationResult();

            result.AddRequired(nameof(Test.TestName), testName);

            var hasItems = items != null && items.Any();
            if (hasItems == false)
                result.AddError(nameof(Test.TestItems), Resources.validate_selectedTestItemsError);

            return result;
        }
    }
}
