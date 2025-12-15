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



        public async Task AddReception(ReceptionAddRequestDto dto, IEnumerable<TestAddRequestDto> tests)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                var param = new DynamicParameters(dto);
                var testTable = TestRepository.GetTestDataTable(tests);
                param.Add("@tests", testTable.AsTableValuedParameter("TestAddType"));

                await conn.ExecuteAsync(
                            "addReception",
                            param,
                            commandType: CommandType.StoredProcedure
                        );
            }
        }

        //public DataTable GetTestDataTable(IEnumerable<TestAddRequestDto> tests)
        //{
        //    if (tests.Any() == false)
        //        return null;

        //    var table = new DataTable();

        //    table.Columns.Add(nameof(TestAddRequestDto.TestName), typeof(string));
        //    table.Columns.Add(nameof(TestAddRequestDto.TestItemIds), typeof(string));

        //    foreach (var item in tests)
        //    {
        //        table.Rows.Add(
        //            item.TestName,
        //            item.TestItemIds
        //        );
        //    }

        //    return table;
        //}

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
