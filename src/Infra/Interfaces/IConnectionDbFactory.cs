using Infra.Repositories;

namespace Infra.Interfaces
{
    public interface IConnectionDbFactory
    {
        IConnectionDbFactory CreateDbConnection(IConnectionDb IConnectionDb);
    }
}
