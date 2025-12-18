using System;
using System.Threading.Tasks;
using ToyProject.Core.Service;
using ToyProject.Model;
using ToyProject.View.IView;

namespace ToyProject.Presenter
{
    public class PatientDetailDialogPresenter : PresenterBase
    {
        public PatientDetailDialogPresenter(IPatientDetailDialogView view, MessageService messageService) : base(messageService)
        {
            _view = view;

            _view.SavePatient += View_SavePatient;
            _view.LoadRequest += View_LoadRequest;
        }

        private readonly IPatientDetailDialogView _view;
        private PatientEditPresenter _patientEditPresenter;

        public Task LoadAsync(Patient patient)
        {
            _patientEditPresenter = new PatientEditPresenter(_view.PatientEditControl, patient);

            return Task.CompletedTask;
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
    }
}
