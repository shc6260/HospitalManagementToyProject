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
        public Task<IEnumerable<PatientResponseDto>> FindPatientsForGnbAsync(string searchText)
        {
            return Task.Run(async () =>
            {
                using (var conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();

                    var patients = await conn.QueryAsync<PatientResponseDto>(
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

        public void SavePatientsAsync(PatientRequestDto dto)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                conn.Execute("addPatient",
                dto,
                commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdatePatientsAsync(PatientRequestDto dto)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                conn.Execute("modifyPatient",
                dto,
                commandType: CommandType.StoredProcedure);
            }
        }
    }
}
