using System.Collections.Generic;
using System.Linq;
using ToyProject.Core.Repositories;
using ToyProject.Model;
using ToyProject.View;

namespace ToyProject.Presenter
{
    public class MainPresenter
    {
        private readonly IMainView _view;
        private readonly List<Patient> _patients;
        private readonly PatientRepository _patientRepository;


        public MainPresenter(IMainView view)
        {
            _patientRepository = new PatientRepository();

            _view = view;
            _patients = CreateSamplePatients();

            _view.PatientSelected += OnPatientSelected;
            _view.ReceptionRequested += OnReceptionRequested;

            _view.SetPatientList(_patients);
        }

        private void OnPatientSelected(object sender, long patientId)
        {
            var patient = _patients.Find(p => p.Id == patientId);
            if (patient != null)
                _view.ShowPatientDetail(patient);
        }

        private void OnReceptionRequested(object sender, long patientId)
        {
            var patient = _patients.Find(p => p.Id == patientId);
            if (patient != null)
            {
                // TODO: 접수 로직
                _view.ShowReceptionMessage(patient);
                _view.ClearSearch();
            }
        }

        private List<Patient> CreateSamplePatients()
        {
            var patients = _patientRepository.FindPatients().Select(Patient.From).ToList();
            return patients;
        }
    }
}
