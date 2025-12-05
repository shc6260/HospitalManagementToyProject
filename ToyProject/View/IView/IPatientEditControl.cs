using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyProject.Model;

namespace ToyProject.View.IView
{
    public interface IPatientEditControl
    {
        Patient GetPatient();

        void SetPatient(Patient patient);
    }
}
