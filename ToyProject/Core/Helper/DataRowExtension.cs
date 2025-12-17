using System;
using System.Data;

namespace ToyProject.Core.Helper
{
    public static class DataRowExtension
    {
        public static string GetString(this DataRow self, string columnName, DataRowVersion version)
        {
            if (self.Table.Columns.Contains(columnName) == false)
                return null;

            var value = self[columnName, version];
            return value == DBNull.Value ? null : Convert.ToString(value);
        }

        public static long GetLong(this DataRow self, string columnName, DataRowVersion version)
        {
            if (self.Table.Columns.Contains(columnName) == false)
                return -1;

            var value = self[columnName, version];
            return value == DBNull.Value ? -1 : Convert.ToInt64(value);
        }

        public static long? GetNullableLong(this DataRow self, string columnName, DataRowVersion version)
        {
            if (self.Table.Columns.Contains(columnName) == false)
                return null;

            var value = self[columnName, version];
            return value == DBNull.Value ? (long?)null : Convert.ToInt64(value);
        }

        public static DateTime? GetNullableDateTime(this DataRow self, string columnName, DataRowVersion version)
        {
            if (self.Table.Columns.Contains(columnName) == false)
                return null;

            var value = self[columnName, version];
            return value == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(value);
        }
    }
}
