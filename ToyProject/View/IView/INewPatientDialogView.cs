using System;

namespace ToyProject.View.IView
{
    public interface INewPatientDialogView
    {
        IPatientEditControl PatientEditControl { get; }

        event EventHandler SavePatient;
    }
}
