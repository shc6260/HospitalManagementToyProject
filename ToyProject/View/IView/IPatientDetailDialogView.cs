using System;
using ToyProject.Model;

namespace ToyProject.View.IView
{
    public interface IPatientDetailDialogView
    {
        IPatientEditControl PatientEditControl { get; }

        event EventHandler SavePatient;

        event EventHandler<Patient> LoadRequest;
    }
}
