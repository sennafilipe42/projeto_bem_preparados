using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Mappings
{
    public class UserMap : IEntityTypeConfiguration<UserEntitie>
    {
        public void Configure(EntityTypeBuilder<UserEntitie> builder)
        {
            builder.ToTable("TREINA_USUARIOS"); //Tabela do Sql

            builder.HasKey(x => x.Usuario); //propriedades da PK

            builder.Property(x => x.Nome) //propriedades do Nome
                   .IsRequired()//é obrigatorio na tabela
                   .HasMaxLength(20)//maximo de 20 letras
                   .HasColumnName("NOME")
                   .HasColumnType("VARCHAR(20)");

            builder.Property(x => x.Senha)
                   .IsRequired()//é obrigatorio na tabela
                   .HasColumnName("SENHA")
                   .HasColumnType("VARCHAR(10)");

            builder.Property(x => x.ValidadeSenha)
                   .HasColumnName("VALIDADE_SENHA")
                   .HasColumnType("DATETIME");
        }

        private object UseIdentityColumn()
        {
            throw new NotImplementedException();
        }
    }
}
