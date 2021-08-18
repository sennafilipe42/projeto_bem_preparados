using System.Collections.Generic;
using Api.Data.Entities;
using Api.Data.Repository;
using Microsoft.Extensions.Configuration;

namespace Api.Data
{
    public class ClientesRepository : RepositoryConnector, Interfaces.IUsuariosRepository
    {

        //Chama o ctor do repositorio herdado
        public ClientesRepository(IConfiguration config) : base(config) { }

        public void add(Usuarios obj)
        {
            throw new System.NotImplementedException();
        }

        public Usuarios Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Usuarios> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Usuarios obj)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Usuarios obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
