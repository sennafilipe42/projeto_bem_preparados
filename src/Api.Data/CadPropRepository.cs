using System.Collections.Generic;
using Api.Data.Entities;
using Microsoft.Extensions.Configuration;

namespace Api.Data
{
    public class CadPropRepository : RepositoryConnector, Interfaces.ICadPropRepository
    {
        public CadPropRepository(IConfiguration config) : base(config) { }

        public void Add(CadastroPropostas obj)
        {
            throw new System.NotImplementedException();
        }

        public CadastroPropostas Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<CadastroPropostas> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Remove(CadastroPropostas obj)
        {
            throw new System.NotImplementedException();
        }

        public void Update(CadastroPropostas obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
