using Domain.Entities;
using Infra.Mappings;
using Microsoft.EntityFrameworkCore;
namespace Infra.Context
{
    public class ContextBase : DbContext
    {
        public ContextBase() { }

        //esse contrutor é necessário pois vamos receber a conexão com o banco
        // via injeção de dependencia, que o aspnet provem para o projeto
        public ContextBase(DbContextOptions<ContextBase> options) : base(options) { }


        //Tabela setada no banco referente ao usuario        
        public virtual DbSet<UserEntitie> Users { get; set; }


        //banco vai saber qual a tabela, via aplicação da configuração UserMap
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserMap());
        }

    }
}
