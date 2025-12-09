using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyProject.Core.Repositories;
using ToyProject.Model;
using ToyProject.View.IView;

namespace ToyProject.Presenter
{
    public class PatientDetailDialogPresenter
    {
        private readonly IPatientDetailDialogView _view;
        private readonly PatientEditPresenter _patientEditPresenter;
        private readonly long? _patientId;
        private readonly PatientRepository _patientRepository;


        public PatientDetailDialogPresenter(IPatientDetailDialogView view, Patient patient)
        {
            _patientRepository = new PatientRepository();

            _view = view;

            _view.SavePatient += View_SavePatient;

            _patientEditPresenter = new PatientEditPresenter(_view.PatientEditControl, patient);
            _patientId = patient?.Id;
        }

        private void View_SavePatient(object sender, EventArgs e)
        {
            var patient = _patientEditPresenter.GetPatient();
            
            if (_patientId == null)
            {
                _patientRepository.SavePatientsAsync(patient.ToRequestDto());
            }

            _patientRepository.UpdatePatientsAsync(patient.WithId(_patientId.Value).ToRequestDto());
        }
    }
}
