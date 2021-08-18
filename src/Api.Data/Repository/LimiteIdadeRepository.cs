using System.Collections.Generic;
using Api.Data.Entities;
using Api.Data.Repository;
using Microsoft.Extensions.Configuration;

namespace Api.Data
{
    public class LimiteIdadeRepository : RepositoryConnector, Interfaces.ILimiteIdadeRepository
    {

        //Chama o ctor do repositorio herdado
        public LimiteIdadeRepository(IConfiguration config) : base(config) { }

        public void add(LimiteIdade obj)
        {
            throw new System.NotImplementedException();
        }

        public LimiteIdade Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<LimiteIdade> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Remove(LimiteIdade obj)
        {
            throw new System.NotImplementedException();
        }

        public void Update(LimiteIdade obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
