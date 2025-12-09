using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using ToyProject.Core.Infrastructure;
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
