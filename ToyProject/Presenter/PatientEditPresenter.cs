using System;
using System.Threading.Tasks;
using ToyProject.Core.Factotry;
using ToyProject.Core.Service;
using ToyProject.Model;
using ToyProject.Properties;
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

            if (string.IsNullOrWhiteSpace(patient.Name) || string.IsNullOrWhiteSpace(patient.SocialSecurityNumber))
                throw new Exception(Resources.Strings_noValueMessage);

            return await _patientService.SavePatientAcync(patient);
        }
    }
}
