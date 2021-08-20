using Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Infra.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntitie
    {
        //metodos assicronos, não fazem na mesma trhead
        //se auto gerenciam 

        //T é qualquer entidade que seja base
        Task<T> Create(T obj);
        Task<T> Update(T obj);
        Task Remove(long id);
        Task<T> Get(long id);
        Task<List<T>> Get();
    }
}
