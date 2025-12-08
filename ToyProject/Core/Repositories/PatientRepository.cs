using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using ToyProject.Core.Infrastructure;
using ToyProject.Model;

namespace ToyProject.Core.Repositories
{
    public class PatientRepository
    {
        public Task<IEnumerable<PatientDto>> FindPatientsForGnb(string searchText)
        {
            return Task.Run(async () =>
            {
                using (var conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();

                    var patients = await conn.QueryAsync<PatientDto>(
                        "findPatientForGnb",
                        param: new
                        {
                            searchText = searchText
                        },
                        commandType: CommandType.StoredProcedure
                    );

                    return patients;
                }
            });
        }

        public void SavePatients(PatientDto patientDto)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                conn.Execute("addPatient",
                new
                {
                    name = patientDto.Name,
                    chartnumber = "1929203",
                    phonenumber = patientDto.PhoneNumber,
                    social_security_number = patientDto.Social_Security_Number,
                    address = patientDto.Address,
                    memo = patientDto.Memo,
                    qualification_info = patientDto.Qualification_Info
                },
                commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdatePatients(PatientDto patientDto)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                conn.Execute("modifyPatient",
                new
                {
                    id = patientDto.Id,
                    name = patientDto.Name,
                    chartnumber = "1929203",
                    phonenumber = patientDto.PhoneNumber,
                    social_security_number = patientDto.Social_Security_Number,
                    address = patientDto.Address,
                    memo = patientDto.Memo,
                    qualification_info = patientDto.Qualification_Info
                },
                commandType: CommandType.StoredProcedure);
            }
        }
    }
}
