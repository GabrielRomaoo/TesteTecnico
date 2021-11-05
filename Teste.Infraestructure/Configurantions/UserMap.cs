using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Teste.Domain.Entities;

namespace Teste.Infraestructure.Data.Configurantions
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .HasColumnName("Nome")
                .IsRequired(true);

            builder.Property(prop => prop.Sobrenome)
                .HasColumnName("Sobrenome")
                .IsRequired(true);

            builder.Property(prop => prop.Email)
                .HasColumnName("Email")
                .IsRequired(true);

            builder.Property(prop => prop.DataNascimento)
                .HasColumnName("Data Nascimento")
                .IsRequired(true);

            builder.Property(prop => prop.Escolaridade)
                .HasColumnName("Escolaridade")
                .IsRequired(true);
                
        }
    }
}
