using System;
using System.Threading.Tasks;
using ToyProject.Core.Factotry;
using ToyProject.Core.Service;
using ToyProject.Model;
using ToyProject.Model.Type;
using ToyProject.View.IView;

namespace ToyProject.Presenter
{
    public class PatientDetailDialogPresenter : PresenterBase
    {
        public PatientDetailDialogPresenter(IPatientDetailDialogView view, MessageService messageService) : base(messageService)
        {
            _view = view;

            _testService = ServiceFactory.GetTestService();

            _view.SavePatient += View_SavePatient;
            _view.LoadRequest += View_LoadRequest;
        }

        private readonly IPatientDetailDialogView _view;
        private PatientEditPresenter _patientEditPresenter;
        private TestService _testService;

        public async Task LoadAsync(Patient patient)
        {
            _patientEditPresenter = new PatientEditPresenter(_view.PatientEditControl, patient);
            var testDetail = await _testService.GetTestsAsync(StatusType.Complete, _patientEditPresenter.LoadedPatientId);
            _view.SetTestItems(testDetail);
        }

        private async void View_SavePatient(object sender, EventArgs e)
        {
            await _messageService.RunInProgressPopupAsync(async () =>
            {
                await _patientEditPresenter.SavePatient();
            });
        }

        private async void View_LoadRequest(object sender, Patient e)
        {
            await _messageService.RunInProgressPopupAsync(async () =>
            {
                await LoadAsync(e);
            });
        }

        public override void Dispose()
        {
            _view.SavePatient -= View_SavePatient;
            _view.LoadRequest -= View_LoadRequest;
            base.Dispose();
        }
    }
}
