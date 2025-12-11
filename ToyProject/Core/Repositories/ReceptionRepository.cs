using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using ToyProject.Core.Factotry;
using ToyProject.Model.Dto;

namespace ToyProject.Core.Repositories
{
    public class ReceptionRepository
    {
        public Task<IEnumerable<ReceptionWithPatientSimpleResponseDto>> FindRecepionWithPatientInfo(DateTime from, DateTime to)
        {
            return Task.Run(async () =>
            {
                using (var conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();

                    var receptions = await conn.QueryAsync<ReceptionWithPatientSimpleResponseDto>(
                        "findReceptionWithPatientSimple",
                        new
                        {
                            reception_start_dt = from,
                            reception_end_dt = to
                        },
                        commandType: CommandType.StoredProcedure
                    );

                    return receptions;
                }
            });
        }

        public Task AddReception(ReceptionAddRequestDto dto)
        {
            return Task.Run(async () =>
            {
                using (var conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();

                    var patients = await conn.ExecuteAsync(
                        "addReception",
                        dto,
                        commandType: CommandType.StoredProcedure
                    );

                    return patients;
                }
            });
        }

        public Task ModifyReception(ReceptionModifyRequestDto dto)
        {
            return Task.Run(async () =>
            {
                using (var conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();

                    var patients = await conn.ExecuteAsync(
                        "modifyReception",
                        dto,
                        commandType: CommandType.StoredProcedure
                    );

                    return patients;
                }
            });
        }

        public Task DeleteReception(long id)
        {
            return Task.Run(async () =>
            {
                using (var conn = DbConnectionFactory.CreateConnection())
                {
                    conn.Open();

                    var patients = await conn.ExecuteAsync(
                        "deleteReception",
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
