using ToyProject.Model;

namespace ToyProject.View.IView
{
    public interface IPatientEditControl
    {
        Patient GetPatient();

        void SetPatient(Patient patient);
    }
}
