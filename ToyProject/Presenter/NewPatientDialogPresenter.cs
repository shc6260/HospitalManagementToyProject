using System;
using ToyProject.Core.Service;
using ToyProject.View.IView;

namespace ToyProject.Presenter
{
    public class NewPatientDialogPresenter : PresenterBase
    {
        public NewPatientDialogPresenter(INewPatientDialogView view, MessageService messageService) : base(messageService)
        {
            _view = view;

            _view.SavePatient += View_SavePatient;

            _patientEditPresenter = new PatientEditPresenter(_view.PatientEditControl);
        }

        private readonly INewPatientDialogView _view;

        private readonly PatientEditPresenter _patientEditPresenter;


        private async void View_SavePatient(object sender, EventArgs e)
        {
            await _messageService.RunInProgressPopupAsync(async () =>
            {
                await _patientEditPresenter.SavePatient();
            });
        }
    }
}
