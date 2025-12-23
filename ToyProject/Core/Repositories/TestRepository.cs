using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using ToyProject.Core.Factotry;
using ToyProject.Model.Dto;
using ToyProject.Model.Type;

namespace ToyProject.Core.Repositories
{
    public class TestRepository : ITestRepository
    {
        public async Task<IEnumerable<TestDetailDto>> GetTestsAsync(StatusType? status = null, long? patientId = null)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                return await conn.QueryAsync<TestDetailDto>(
                    "findTest",
                    new { status = status?.ToString(), patientId = patientId },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public async Task AddTestsAsync(IEnumerable<TestAddRequestDto> tests, long receptionId)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                var param = new DynamicParameters();
                param.Add("@" + nameof(TestAddRequestDto.Reception_Id), receptionId);

                var testTable = GetTestDataTable(tests);
                param.Add("@tests", testTable.AsTableValuedParameter("TestAddType"));

                await conn.ExecuteAsync
                (
                    "addTests",
                    param,
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public static DataTable GetTestDataTable(IEnumerable<TestAddRequestDto> tests)
        {
            if (tests.Any() == false)
                return null;

            var table = new DataTable();

            table.Columns.Add(nameof(TestAddRequestDto.TestName), typeof(string));
            table.Columns.Add(nameof(TestAddRequestDto.TestItemIds), typeof(string));

            foreach (var item in tests)
            {
                table.Rows.Add(
                    item.TestName,
                    item.TestItemIds
                );
            }

            return table;
        }

        public async Task ModifyTestsAsync(IEnumerable<TestModifyRequestDto> tests)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                var table = CreateModifyTestTable(tests);

                var param = new DynamicParameters();
                param.Add(
                    "@tests",
                    table.AsTableValuedParameter("ModifyTestType")
                );

                await conn.ExecuteAsync(
                    "modifyTests",
                    param,
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        private DataTable CreateModifyTestTable(IEnumerable<TestModifyRequestDto> items)
        {
            var table = new DataTable();

            table.Columns.Add("test_code", typeof(Guid));
            table.Columns.Add("status", typeof(string));
            table.Columns.Add("test_name", typeof(string));
            table.Columns.Add("included_test_item_ids", typeof(string));
            table.Columns.Add("excluded_test_item_ids", typeof(string));

            foreach (var i in items)
            {
                table.Rows.Add(
                    i.Test_Code,
                    i.Status,
                    i.Test_Name,
                    i.Included_Test_Item_Ids,
                    i.Excluded_Test_Item_Ids
                );
            }

            return table;
        }

        public async Task DeleteTestsAsync(IEnumerable<string> codes)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                var param = new DynamicParameters();
                var table = new DataTable();

                table.Columns.Add("code", typeof(string));

                foreach (var code in codes)
                {
                    table.Rows.Add(
                        code
                    );
                }

                param.Add("@codes", table.AsTableValuedParameter("CodeListType"));

                await conn.ExecuteAsync
                (
                    "deleteTests",
                    param,
                    commandType: CommandType.StoredProcedure
                );
            }
        }
    }
}
