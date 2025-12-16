using System;
using ToyProject.Model;
using ToyProject.View.IView;

namespace ToyProject.Presenter
{
    public class PatientDetailDialogPresenter
    {
        public PatientDetailDialogPresenter(IPatientDetailDialogView view, Patient patient)
        {
            _view = view;

            _view.SavePatient += View_SavePatient;

            _patientEditPresenter = new PatientEditPresenter(_view.PatientEditControl, patient);
            _patientId = patient?.Id;
        }

        private readonly IPatientDetailDialogView _view;
        private readonly PatientEditPresenter _patientEditPresenter;
        private readonly long? _patientId;

        private async void View_SavePatient(object sender, EventArgs e)
        {
            await _patientEditPresenter.SavePatient();
        }
    }
}
