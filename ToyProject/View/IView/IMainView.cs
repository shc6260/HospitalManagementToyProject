using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyProject.Model;

namespace ToyProject.View
{
    public interface IMainView
    {
        event EventHandler<long> PatientSelected;
        event EventHandler<long> ReceptionRequested;
        event EventHandler<string> SearchTextChanged;

        void SetPatientList(IList<Patient> patients);

        void ShowPatientDetail(Patient patient);

        void ShowReceptionMessage(Patient patient);

        void ClearSearch();
    }
}
