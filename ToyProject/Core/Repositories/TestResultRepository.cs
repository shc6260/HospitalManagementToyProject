using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using ToyProject.Core.Factotry;
using ToyProject.Model.Dto;

namespace ToyProject.Core.Repositories
{
    public class TestResultRepository
    {
        public async Task AddTestResultsAsync(IEnumerable<TestResultRequestDto> results)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                var param = new DynamicParameters();

                var testTable = GetTestDataTable(results);
                param.Add("@items", testTable.AsTableValuedParameter("TestResultTva"));

                await conn.ExecuteAsync
                (
                    "bulkAddTestresult",
                    param,
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public async Task ModifyTestResultsAsync(IEnumerable<TestResultRequestDto> results)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                var param = new DynamicParameters();

                var testTable = GetTestDataTable(results);
                param.Add("@items", testTable.AsTableValuedParameter("TestResultTva"));

                await conn.ExecuteAsync
                (
                    "bulkModifyTestresult",
                    param,
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public static DataTable GetTestDataTable(IEnumerable<TestResultRequestDto> results)
        {
            if (results.Any() == false)
                return null;

            var table = new DataTable();

            table.Columns.Add(nameof(TestResultRequestDto.Id), typeof(long));
            table.Columns.Add(nameof(TestResultRequestDto.TestId), typeof(long));
            table.Columns.Add(nameof(TestResultRequestDto.Desison), typeof(string));
            table.Columns.Add(nameof(TestResultRequestDto.JudgementValue), typeof(string));
            table.Columns.Add(nameof(TestResultRequestDto.EquipmentId), typeof(long));
            table.Columns.Add(nameof(TestResultRequestDto.TesterId), typeof(long));
            table.Columns.Add(nameof(TestResultRequestDto.TestDt), typeof(DateTime));

            foreach (var item in results)
            {
                table.Rows.Add(
                    DbValue(item.Id),
                    item.TestId,
                    (object)item.Desison ?? DBNull.Value,
                    (object)item.JudgementValue ?? DBNull.Value,
                    DbValue(item.EquipmentId),
                    DbValue(item.TesterId),
                    DbValue(item.TestDt)
                );
            }

            return table;
        }

        private static object DbValue<T>(T? value) where T : struct
        {
            return value.HasValue ? (object)value.Value : DBNull.Value;
        }
    }
}
