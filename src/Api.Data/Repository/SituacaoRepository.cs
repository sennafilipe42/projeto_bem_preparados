using System.Collections.Generic;
using Api.Data.Entities;
using Api.Data.Repository;
using Microsoft.Extensions.Configuration;

namespace Api.Data
{
    public class SituacaoRepository : RepositoryConnector, Interfaces.ISituacaoRepository
    {

        //Chama o ctor do repositorio herdado
        public SituacaoRepository(IConfiguration config) : base(config) { }

        public void add(Situacao obj)
        {
            throw new System.NotImplementedException();
        }

        public Situacao Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Situacao> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Situacao obj)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Situacao obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
