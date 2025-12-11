using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using ToyProject.Core.Factotry;
using ToyProject.Model;

namespace ToyProject.Core.Repositories
{
    public class PatientRepository
    {
        public async Task<IEnumerable<PatientResponseDto>> FindPatientsForGnbAsync(string searchText)
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
        }

        public async Task<long> AddPatientsAsync(PatientAddRequestDto dto)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                return await conn.ExecuteScalarAsync<long>
                (
                    "addPatient",
                    dto,
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public async Task<long> ModifyPatientsAsync(PatientRequestDto dto)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                await conn.ExecuteAsync
                (
                    "modifyPatient",
                    dto,
                    commandType: CommandType.StoredProcedure
                );

                return dto.Id.Value;
            }
        }
    }
}
