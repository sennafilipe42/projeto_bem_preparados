using System.Collections.Generic;

namespace Api.Data.Interfaces
{
    public interface IClientesRepository<T> where T : class
    {

        IEnumerable<T> GetAll();

        T Get(int id);
        void add(T obj);

        void Remove(T obj);

        void Update(T obj);
    }
}
