using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using ToyProject.Core.Infrastructure;
using ToyProject.Model;

namespace ToyProject.Core.Repositories
{
    public class TesterRepository
    {
        public Task<IEnumerable<TesterResponseDto>> FindAll()
        {
            return Task.Run(async () =>
            {
                using (var conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();

                    var patients = await conn.QueryAsync<TesterResponseDto>(
                        "select * from Tester"
                    );

                    return patients;
                }
            });
        }

        public Task AddTester(TesterAddRequestDto dto)
        {
            return Task.Run(async () =>
            {
                using (var conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();

                    var patients = await conn.ExecuteAsync(
                        "addTester",
                        dto,
                        commandType: CommandType.StoredProcedure
                    );

                    return patients;
                }
            });
        }

        public Task ModifyTester(TesterRequestDto dto)
        {
            return Task.Run(async () =>
            {
                using (var conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();

                    var patients = await conn.ExecuteAsync(
                        "modifyTester",
                        dto,
                        commandType: CommandType.StoredProcedure
                    );

                    return patients;
                }
            });
        }

        public Task DeleteTester(long id)
        {
            return Task.Run(async () =>
            {
                using (var conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();

                    var patients = await conn.ExecuteAsync(
                        "delete_tester",
                        new
                        {
                            id = id
                        },
                        commandType: CommandType.StoredProcedure
                    );

                    return patients;
                }
            });
        }
    }
}
