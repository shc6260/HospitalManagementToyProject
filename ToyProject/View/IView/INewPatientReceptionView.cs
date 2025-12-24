using System;

namespace ToyProject.View.IView
{
    public interface INewPatientReceptionView
    {
        IPatientEditControl PatientEditControl { get; }

        IReceptionControlView IReceptionControlView { get; }

        void Close();

        event EventHandler SavePatient;
    }
}
