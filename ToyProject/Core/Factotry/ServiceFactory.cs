using ToyProject.Core.Repositories;
using ToyProject.Core.Repositories.InMemory;
using ToyProject.Core.Service;

namespace ToyProject.Core.Factotry
{
    public static class ServiceFactory
    {
        private static readonly InMemoryRepositoryContext MemoryContext = new InMemoryRepositoryContext();

        public static ReceptionService GetReceptionService()
        {
#if MemoryDebug
            return new ReceptionService(
                new InMemoryReceptionRepository(MemoryContext),
                new InMemoryTestRepository(MemoryContext),
                new InMemoryPatientRepository(MemoryContext));
#endif
            return new ReceptionService(new ReceptionRepository(), new TestRepository(), new PatientRepository());
        }

        public static TestService GetTestService()
        {
#if MemoryDebug
            return new TestService(new InMemoryTestRepository(MemoryContext), new InMemoryTestResultRepository(MemoryContext));
#endif

            return new TestService(new TestRepository(), new TestResultRepository());
        }

        public static PatientService GetPatientService()
        {
#if MemoryDebug
            return new PatientService(new InMemoryPatientRepository(MemoryContext));
#endif

            return new PatientService(new PatientRepository());
        }

        public static TesterService GetTesterService()
        {
#if MemoryDebug
            return new TesterService(new InMemoryTesterRepository(MemoryContext));
#endif

            return new TesterService(new TesterRepository());
        }

        public static TestItemService GetTestItemService()
        {
#if MemoryDebug
            return new TestItemService(new InMemoryTestItemRepository(MemoryContext));
#endif

            return new TestItemService(new TestItemRepository());
        }

        public static EquipmentService GetEquipmentService()
        {
#if MemoryDebug
            return new EquipmentService(new InMemoryEquipmentRepository(MemoryContext));
#endif

            return new EquipmentService(new EquipmentRepository());
        }
    }
}
