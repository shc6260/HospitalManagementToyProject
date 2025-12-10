using System;
using System.Collections.Generic;
using ToyProject.Model;

namespace ToyProject.View
{
    public interface IMainView
    {
        event EventHandler<long> PatientSelected;
        event EventHandler<long> ReceptionRequested;
        event EventHandler<string> SearchTextChanged;

        void SetPatientList(IEnumerable<Patient> patients);

        void ShowPatientDetail(Patient patient);

        void ShowReceptionMessage(Patient patient);

        void ClearSearch();
    }
}
