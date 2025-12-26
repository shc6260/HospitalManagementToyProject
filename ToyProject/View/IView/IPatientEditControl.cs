using ToyProject.Model;
using ToyProject.Core.Validation;

namespace ToyProject.View.IView
{
    public interface IPatientEditControl
    {
        Patient GetPatient();

        void SetPatient(Patient patient);

        void ShowErrors(ValidationResult validationResult);
    }
}
