using System.Data;

namespace Schaudepots.Api.Data
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
