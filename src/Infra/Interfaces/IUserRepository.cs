using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;


namespace Infra.Interfaces
{
    public interface IUserRepository : IBaseRepository<UserEntitie>
    {
        //Usando task para fazer chamadas assincronas

        Task<UserEntitie> GetByUsuario(string usuario);
        Task<List<UserEntitie>> SearchByUsuario(string usuario);
        Task<List<UserEntitie>> SearchByNome(string nome);

    }
}
