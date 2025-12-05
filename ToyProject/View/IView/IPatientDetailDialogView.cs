using System;

namespace ToyProject.View.IView
{
    public interface IPatientDetailDialogView
    {
        IPatientEditControl PatientEditControl { get; }

        event EventHandler SavePatient;
    }
}
