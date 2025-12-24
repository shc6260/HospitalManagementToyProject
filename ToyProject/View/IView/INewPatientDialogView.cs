using System;

namespace ToyProject.View.IView
{
    public interface INewPatientDialogView
    {
        IPatientEditControl PatientEditControl { get; }

        void Close();

        event EventHandler SavePatient;
    }
}
