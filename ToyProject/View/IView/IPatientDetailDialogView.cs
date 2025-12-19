using System;
using System.Collections.Generic;
using ToyProject.Model;

namespace ToyProject.View.IView
{
    public interface IPatientDetailDialogView
    {
        IPatientEditControl PatientEditControl { get; }

        void SetTestItems(IEnumerable<TestDetail> testITems);

        event EventHandler SavePatient;

        event EventHandler<Patient> LoadRequest;
    }
}
