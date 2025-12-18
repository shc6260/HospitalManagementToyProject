using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using ToyProject.Core.Factotry;
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

        public async Task<bool> HasChanged(DateTime checkTime)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                var hasChanged = await conn.ExecuteScalarAsync<int>(
                    @"
                SELECT CASE
                    WHEN EXISTS (
                        SELECT 1
                        FROM Tester
                        WHERE modified_dt > @checkTime
                    )
                    THEN 1 ELSE 0
                END
                ",
                    new { @checkTime = checkTime }
                );

                return hasChanged == 1;
            }
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
