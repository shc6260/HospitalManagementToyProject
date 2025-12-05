using ToyProject.Model;
using ToyProject.View.IView;

namespace ToyProject.Presenter
{
    public class PatientEditPresenter
    {
        private readonly IPatientEditControl _view;

        public PatientEditPresenter(IPatientEditControl view, Patient patient)
        {
            _view = view;
            _view.SetPatient(patient);
        }

        public Patient GetPatient()
        {
            return _view.GetPatient();
        }
    }
}
