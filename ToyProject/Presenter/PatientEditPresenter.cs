using System.Threading.Tasks;
using ToyProject.Core.Factotry;
using ToyProject.Core.Service;
using ToyProject.Model;
using ToyProject.View.IView;

namespace ToyProject.Presenter
{
    public class PatientEditPresenter
    {
        public PatientEditPresenter(IPatientEditControl view, Patient patient = null)
        {
            _patientService = ServiceFactory.GetPatientService();

            _view = view;
            _view.SetPatient(patient);
            _loadedPatientId = patient?.Id;
        }

        private readonly IPatientEditControl _view;
        private readonly PatientService _patientService;
        private long? _loadedPatientId;

        public async Task<long> SavePatient()
        {
            var patient = _loadedPatientId == null ? _view.GetPatient() : _view.GetPatient().WithId(_loadedPatientId.Value);
            return await _patientService.SavePatientAcync(patient);
        }
    }
}
