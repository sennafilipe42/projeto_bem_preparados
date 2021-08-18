using System.Collections.Generic;
using Api.Data.Entities;
using Api.Data.Repository;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace Api.Data
{
    public class UsuariosRepository : RepositoryConnector, Interfaces.IUsuariosRepository
    {

        //Chama o ctor do repositorio herdado
        public UsuariosRepository(IConfiguration config) : base(config) { }

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
            IEnumerable<Usuarios> retorno;
            string sql = "SELECT * FROM Usuarios";
            using (var con = new SqlConnection(base.GetConnection()))
            {
                retorno = con.Query<Usuarios>(sql);

            }

            return retorno;
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
