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
        public async Task<IEnumerable<TesterResponseDto>> FindAll()
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                var patients = await conn.QueryAsync<TesterResponseDto>(
                    "select * from Tester"
                );

                return patients;
            }
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

        public async Task AddTester(TesterAddRequestDto dto)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                await conn.ExecuteAsync(
                    "addTester",
                    dto,
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public async Task ModifyTester(TesterRequestDto dto)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                await conn.ExecuteAsync(
                    "modifyTester",
                    dto,
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public async Task DeleteTester(long id)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                await conn.ExecuteAsync(
                    "delete_tester",
                    new
                    {
                        id = id
                    },
                    commandType: CommandType.StoredProcedure
                );
            }
        }
    }
}
