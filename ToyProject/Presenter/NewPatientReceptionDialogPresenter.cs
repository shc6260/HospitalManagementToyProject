using ToyProject.Core.Events;
using ToyProject.Core.Factotry;
using ToyProject.Core.Helper;
using ToyProject.Core.Service;
using ToyProject.Properties;
using ToyProject.View.IView;

namespace ToyProject.Presenter
{
    public class NewPatientReceptionDialogPresenter : PresenterBase
    {
        public NewPatientReceptionDialogPresenter(INewPatientReceptionView view, MessageService messageService) : base(messageService)
        {
            _view = view;
            _view.SavePatient += ViewSavePatient;

            _receptionService = ServiceFactory.GetReceptionService();
        }


        private readonly INewPatientReceptionView _view;
        private readonly ReceptionService _receptionService;


        private async void ViewSavePatient(object sender, System.EventArgs e)
        {
            var patient = _view.PatientEditControl.GetPatient();
            if (string.IsNullOrWhiteSpace(patient.Name) || string.IsNullOrWhiteSpace(patient.SocialSecurityNumber))
            {
                _messageService.ShowError(Resources.Strings_noValueMessage);
                return;
            }

            var reception = _view.IReceptionControlView.GetReception();

            await _messageService.RunInProgressPopupAsync(async () =>
            {
                await _receptionService.AddNewPatientReception(patient, reception);
                EventBus.Instance.Publish(new ReceptionChangedEventArgs());
                _view.Close();
            });
        }

        public override void Dispose()
        {
            _view.SavePatient -= ViewSavePatient;
            base.Dispose();
        }
    }
}
