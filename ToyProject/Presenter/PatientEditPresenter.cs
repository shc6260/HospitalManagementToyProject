using System.Threading.Tasks;
using ToyProject.Core.Factotry;
using ToyProject.Core.Service;
using ToyProject.Model;
using ToyProject.Presenter.Validation;
using ToyProject.View.IView;

namespace ToyProject.Presenter
{
    public class PatientEditPresenter : PresenterBase
    {
        public PatientEditPresenter(IPatientEditControl view, Patient patient = null, MessageService messageService = null) : base(messageService)
        {
            _patientService = ServiceFactory.GetPatientService();

            _view = view;
            _view.SetPatient(patient);
            LoadedPatientId = patient?.Id;
        }

        private readonly IPatientEditControl _view;
        private readonly PatientService _patientService;
        public long? LoadedPatientId { get; private set; }

        public async Task<long?> SavePatient()
        {
            var patient = _view.GetPatient();
            var validationResult = PatientValidator.Validate(patient);
            _view.ShowErrors(validationResult);

            if (validationResult.IsValid == false)
            {
                _messageService.ShowError(validationResult.ErrorMessage);
                return null;
            }

            if (LoadedPatientId != null)
                patient = patient.WithId(LoadedPatientId.Value);

            return await _patientService.SavePatientAcync(patient);
        }
    }
}
