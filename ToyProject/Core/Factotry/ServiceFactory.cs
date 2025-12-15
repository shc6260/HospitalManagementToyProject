using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyProject.Core.Repositories;
using ToyProject.Core.Service;

namespace ToyProject.Core.Factotry
{
    public static class ServiceFactory
    {
        public static ReceptionService GetReceptionService()
        {
            return new ReceptionService(new ReceptionRepository(), new TestRepository(), new PatientRepository());
        }
    }
}
