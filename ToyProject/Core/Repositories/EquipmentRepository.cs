using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using ToyProject.Core.Factotry;
using ToyProject.Model.Dto;

namespace ToyProject.Core.Repositories
{
    public class EquipmentRepository
    {
        public Task<IEnumerable<EquipmentResponseDto>> FindAll()
        {
            return Task.Run(async () =>
            {
                using (var conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();

                    var patients = await conn.QueryAsync<EquipmentResponseDto>(
                        "select * from Equipment"
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
                        FROM Equipment
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

        public Task AddEquipment(EquipmentAddRequestDto dto)
        {
            return Task.Run(async () =>
            {
                using (var conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();

                    var patients = await conn.ExecuteAsync(
                        "addEquipment",
                        dto,
                        commandType: CommandType.StoredProcedure
                    );

                    return patients;
                }
            });
        }

        public Task ModifyEquipment(EquipmentRequestDto dto)
        {
            return Task.Run(async () =>
            {
                using (var conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();

                    var patients = await conn.ExecuteAsync(
                        "modifyEquipment",
                        dto,
                        commandType: CommandType.StoredProcedure
                    );

                    return patients;
                }
            });
        }

        public Task DeleteEquipment(long id)
        {
            return Task.Run(async () =>
            {
                using (var conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();

                    var patients = await conn.ExecuteAsync(
                        "deleteEquipment",
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
