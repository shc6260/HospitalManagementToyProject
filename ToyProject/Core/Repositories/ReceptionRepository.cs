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
        public async Task<IEnumerable<ReceptionWithPatientSimpleResponseDto>> FindRecepionWithPatientInfo(DateTime from, DateTime to)
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
        }

        public async Task<IEnumerable<ReceptionResponseDto>> FindReceptionWithTests(long id)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                var receptions = await conn.QueryAsync<ReceptionResponseDto>(
                    "findReception",
                    new
                    {
                        id = id
                    },
                    commandType: CommandType.StoredProcedure
                );

                return receptions;
            }
        }



        public async Task AddReception(ReceptionAddRequestDto dto)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        var result = await conn.ExecuteScalarAsync<long>(
                            "addReception",
                            dto,
                            commandType: CommandType.StoredProcedure
                        );

                        await conn.ExecuteAsync(
                             "addTest",
                             dto,
                             commandType: CommandType.StoredProcedure
                         );


                        tran.Commit();
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        public async Task ModifyReception(ReceptionModifyRequestDto dto)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                var patients = await conn.ExecuteAsync(
                    "modifyReception",
                    dto,
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public async Task DeleteReception(long id)
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
            }
        }
    }
}
