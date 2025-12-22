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
        public async Task<IEnumerable<EquipmentResponseDto>> FindAll()
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                var patients = await conn.QueryAsync<EquipmentResponseDto>(
                    "select * from Equipment"
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

        public async Task AddEquipment(EquipmentAddRequestDto dto)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                await conn.ExecuteAsync(
                    "addEquipment",
                    dto,
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public async Task ModifyEquipment(EquipmentRequestDto dto)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                await conn.ExecuteAsync(
                    "modifyEquipment",
                    dto,
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public async Task DeleteEquipment(long id)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                await conn.ExecuteAsync(
                    "deleteEquipment",
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
