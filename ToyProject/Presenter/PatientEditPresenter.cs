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
            LoadedPatientId = patient?.Id;
        }

        private readonly IPatientEditControl _view;
        private readonly PatientService _patientService;
        public long? LoadedPatientId { get; private set; }

        public async Task<long> SavePatient()
        {
            var patient = LoadedPatientId == null ? _view.GetPatient() : _view.GetPatient().WithId(LoadedPatientId.Value);
            return await _patientService.SavePatientAcync(patient);
        }
    }
}
