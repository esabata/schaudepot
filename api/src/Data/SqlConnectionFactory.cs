using System.Data;
using System.Data.SqlClient;

namespace Schaudepots.Api.Data
{
    public class SqlConnectionFactory : IDbConnectionFactory
    {
        private readonly string connectionString;

        public SqlConnectionFactory(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            var c = new SqlConnection(connectionString);

            c.Open();

            return c;
        }
    }
}