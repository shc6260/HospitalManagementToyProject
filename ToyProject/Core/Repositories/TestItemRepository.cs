using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using ToyProject.Core.Factotry;
using ToyProject.Model.Dto;

namespace ToyProject.Core.Repositories
{
    public class TestItemRepository
    {
        public async Task<IEnumerable<TestItemResponseDto>> FindAll()
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                var patients = await conn.QueryAsync<TestItemResponseDto>(
                    "select * from TestItem"
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
                        FROM TestItem
                        WHERE modified_dt > @checkTime
                    )
                    THEN 1 ELSE 0
                END
                ",
                    new { checkTime = checkTime }
                );

                return hasChanged == 1;
            }
        }

        public async Task AddTestItem(TestItemAddRequestDto dto)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                await conn.ExecuteAsync(
                    "addTestitem",
                    dto,
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public async Task ModifyTestItem(TestItemRequestDto dto)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                await conn.ExecuteAsync(
                    "modifyTestitem",
                    dto,
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public async Task DeleteTestItem(long id)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                await conn.ExecuteAsync(
                    "deleteTestitem",
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
