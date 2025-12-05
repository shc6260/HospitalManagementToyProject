using System.Data;
using System.Data.SqlClient;

namespace ToyProject.Core.Infrastructure
{
    public class DbConnectionFactory
    {
        public static IDbConnection CreateConnection()
        {
            string connString = @"Server=DESKTOP-P3A2S6M\SQLEXPRESS;Database=TestDatabaseV2;Integrated Security=True;";
            return new SqlConnection(connString);
        }
    }
}
