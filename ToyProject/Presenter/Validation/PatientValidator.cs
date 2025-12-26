using System.Linq;
using ToyProject.Core.Validation;
using ToyProject.Model;
using ToyProject.Properties;

namespace ToyProject.Presenter.Validation
{
    public static class PatientValidator
    {
        public static ValidationResult Validate(Patient patient)
        {
            var result = new ValidationResult();

            if (patient == null)
                return result;

            result.AddRequired(nameof(Patient.Name), patient.Name);

            if (result.AddRequired(nameof(Patient.SocialSecurityNumber), patient.SocialSecurityNumber) == false)
            {
                var normalized = patient.SocialSecurityNumber.Replace("-", "").Trim();
                if (normalized.Length != 13 || !normalized.All(char.IsDigit))
                    result.AddError(nameof(Patient.SocialSecurityNumber), Resources.validate_socialNumberError);
            }

            return result;
        }
    }
}
