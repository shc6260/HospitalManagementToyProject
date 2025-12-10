using System;
using ToyProject.Core.Repositories;
using ToyProject.Core.Service;
using ToyProject.Model;
using ToyProject.View.IView;

namespace ToyProject.Presenter
{
    public class PatientDetailDialogPresenter
    {
        public PatientDetailDialogPresenter(IPatientDetailDialogView view, Patient patient)
        {
            _patientService = new PatientService(new PatientRepository());

            _view = view;

            _view.SavePatient += View_SavePatient;

            _patientEditPresenter = new PatientEditPresenter(_view.PatientEditControl, patient);
            _patientId = patient?.Id;
        }

        private readonly IPatientDetailDialogView _view;
        private readonly PatientEditPresenter _patientEditPresenter;
        private readonly long? _patientId;
        private readonly PatientService _patientService;

        private async void View_SavePatient(object sender, EventArgs e)
        {
            await _patientEditPresenter.SavePatient();
        }
    }
}
