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
            builder.ToTable("User"); //Tabela do Sql

            builder.HasKey(x => x.Id); //PK

            builder.Property(x => x.Nome) //propriedades da Nome
                   .IsRequired()//é obrigatorio na tabela
                   .HasMaxLength(80)//maximo de 80 letras
                   .HasColumnName("nome")
                   .HasColumnType("VARCHAR(80)");

            builder.Property(x => x.Usuario) //propriedades da PK
                   .IsRequired()//é obrigatorio na tabela
                   .HasMaxLength(14)//maximo de 80 letras
                   .HasColumnName("usuario")
                   .HasColumnType("VARCHAR(14)");

            builder.Property(x => x.Senha) //propriedades da PK
                   .IsRequired()//é obrigatorio na tabela
                   .HasColumnName("senha")
                   .HasColumnType("VARCHAR(30)");

            builder.Property(x => x.ValidadeSenha) //propriedades da PK
                   .HasColumnName("validadeSenha")
                   .HasColumnType("DATETIME");
        }

        private object UseIdentityColumn()
        {
            throw new NotImplementedException();
        }
    }
}
