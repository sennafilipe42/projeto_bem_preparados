using System.Collections.Generic;
using Api.Data.Entities;
using Api.Data.Repository;
using Microsoft.Extensions.Configuration;

namespace Api.Data
{
    public class ConvenioRepository : RepositoryConnector, Interfaces.IConvenioRepository
    {

        //Chama o ctor do repositorio herdado
        public ConvenioRepository(IConfiguration config) : base(config) { }

        public void add(Convenio obj)
        {
            throw new System.NotImplementedException();
        }

        public Convenio Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Convenio> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Convenio obj)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Convenio obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
