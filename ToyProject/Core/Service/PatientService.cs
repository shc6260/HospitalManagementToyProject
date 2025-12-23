using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyProject.Core.Repositories;
using ToyProject.Model;

namespace ToyProject.Core.Service
{
    public class PatientService
    {
        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        private IPatientRepository _patientRepository;

        public async Task<IEnumerable<Patient>> FindPatientsForGnbAsync(string searchText)
        {
            var result = await _patientRepository.FindPatientsForGnbAsync(searchText);
            return result.Select(Patient.From);
        }

        public Task<long> SavePatientAcync(Patient data)
        {
            if (data == null)
                return Task.FromResult<long>(-1);

            if (data.Id == null)
                return _patientRepository.AddPatientsAsync(data.ToAddRequestDto());

            return _patientRepository.ModifyPatientsAsync(data.ToRequestDto());
        }
    }
}
