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

        public static TestService GetTestService()
        {
            return new TestService(new TestRepository(), new TestResultRepository());
        }

        public static PatientService GetPatientService()
        {
            return new PatientService(new PatientRepository());
        }

        public static TesterService GetTesterService()
        {
            return new TesterService(new TesterRepository());
        }

        public static TestItemService GetTestItemService()
        {
            return new TestItemService(new TestItemRepository());
        }

        public static EquipmentService GetEquipmentService()
        {
            return new EquipmentService(new EquipmentRepository());
        }
    }
}
