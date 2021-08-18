using System.Collections.Generic;
using Api.Data.Entities;
using Api.Data.Repository;
using Microsoft.Extensions.Configuration;

namespace Api.Data
{
    public class CadastroPropostaRepository : RepositoryConnector, Interfaces.ICadastroPropostaRepository
    {

        //Chama o ctor do repositorio herdado
        public CadastroPropostaRepository(IConfiguration config) : base(config) { }

        public void add(CadastroPropostas obj)
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
