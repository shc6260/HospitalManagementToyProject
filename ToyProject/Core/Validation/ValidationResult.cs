using System.Collections.Generic;
using System.Linq;
using ToyProject.Properties;

namespace ToyProject.Core.Validation
{
    public class ValidationResult
    {
        private readonly Dictionary<string, string> _errors = new Dictionary<string, string>();

        public IReadOnlyDictionary<string, string> Errors => _errors;

        public string ErrorMessage => Errors.FirstOrDefault().Value;

        public bool IsValid => !_errors.Any();

        public void AddError(string fieldName, string message)
        {
            if (string.IsNullOrWhiteSpace(fieldName) || string.IsNullOrWhiteSpace(message))
                return;

            _errors[fieldName] = message;
        }

        public bool AddRequired(string fieldName, string value, string message = null)
        {
            if (string.IsNullOrWhiteSpace(value) == false)
                return false;

            AddError(fieldName, message ?? Resources.Strings_noValueMessage);
            return true;
        }
    }
}
