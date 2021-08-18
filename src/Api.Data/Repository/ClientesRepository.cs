using System.Collections.Generic;
using Api.Data.Entities;
using Api.Data.Repository;
using Microsoft.Extensions.Configuration;

namespace Api.Data
{
    public class ClientesRepository : RepositoryConnector, Interfaces.IClientesRepository
    {

        //Chama o ctor do repositorio herdado
        public ClientesRepository(IConfiguration config) : base(config) { }

        public void add(Clientes obj)
        {
            throw new System.NotImplementedException();
        }

        public Clientes Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Clientes> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Clientes obj)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Clientes obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
