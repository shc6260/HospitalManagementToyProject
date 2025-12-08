using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyProject.Core.Helper;
using ToyProject.Core.Repositories;
using ToyProject.Model;
using ToyProject.View;

namespace ToyProject.Presenter
{
    public class MainPresenter
    {
        public MainPresenter(IMainView view)
        {
            _patientRepository = new PatientRepository();

            _view = view;

            _view.PatientSelected += OnPatientSelected;
            _view.ReceptionRequested += OnReceptionRequested;
            _view.SearchTextChanged += OnSearchTextChanged;
        }

        private readonly IMainView _view;
        private List<Patient> _patients;
        private readonly PatientRepository _patientRepository;
        private string _searchText;


        private DelayInvoker _searchInvoker;

        public DelayInvoker SearchInvoker
        {
            get
            {
                if (_searchInvoker == null)
                {
                    _searchInvoker = new DelayInvoker
                    (
                        300,
                        async () =>
                        {
                            _patients = await GetPatients();
                            _view.SetPatientList(_patients);
                        }
                    );
                }

                return _searchInvoker;
            }
        }

        private void OnSearchTextChanged(object sender, string searchText)
        {
            _searchText = searchText;
            SearchInvoker.Invoke();
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
                _view.ShowReceptionMessage(patient);
                _view.ClearSearch();
            }
        }

        private async Task<List<Patient>> GetPatients()
        {
            var patients = (await _patientRepository.FindPatientsForGnb(_searchText)).Select(Patient.From).ToList();
            return patients;
        }
    }
}
