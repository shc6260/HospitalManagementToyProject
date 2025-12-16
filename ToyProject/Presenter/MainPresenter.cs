using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyProject.Core.Factotry;
using ToyProject.Core.Helper;
using ToyProject.Core.Service;
using ToyProject.Model;
using ToyProject.View;

namespace ToyProject.Presenter
{
    public class MainPresenter : PresenterBase
    {
        public MainPresenter(IMainView view, MessageService messageService) : base(messageService)
        {
            _patientService = ServiceFactory.GetPatientService();

            _view = view;

            _view.PatientSelected += OnPatientSelected;
            _view.ReceptionRequested += OnReceptionRequested;
            _view.SearchTextChanged += OnSearchTextChanged;
        }

        private readonly IMainView _view;
        private IEnumerable<Patient> _patients;
        private readonly PatientService _patientService;
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
            var patient = _patients.FirstOrDefault(p => p.Id == patientId);
            if (patient != null)
                _view.ShowPatientDetail(patient);
        }

        private void OnReceptionRequested(object sender, long patientId)
        {
            var patient = _patients.FirstOrDefault(p => p.Id == patientId);
            if (patient != null)
            {
                _view.ShowReceptionMessage(patient);
                _view.ClearSearch();
            }
        }

        private async Task<IEnumerable<Patient>> GetPatients()
        {
            return await _patientService.FindPatientsForGnbAsync(_searchText);
        }
    }
}
