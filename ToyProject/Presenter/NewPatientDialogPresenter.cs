using System;
using ToyProject.View.IView;

namespace ToyProject.Presenter
{
    public class NewPatientDialogPresenter
    {
        public NewPatientDialogPresenter(INewPatientDialogView view)
        {
            _view = view;

            _view.SavePatient += View_SavePatient;

            _patientEditPresenter = new PatientEditPresenter(_view.PatientEditControl);
        }

        private INewPatientDialogView _view;

        private readonly PatientEditPresenter _patientEditPresenter;


        private async void View_SavePatient(object sender, EventArgs e)
        {
            await _patientEditPresenter.SavePatient();
        }
    }
}
