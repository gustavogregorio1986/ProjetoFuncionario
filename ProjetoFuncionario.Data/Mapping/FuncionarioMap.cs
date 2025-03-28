using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoFuncionario.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFuncionario.Data.Mapping
{
    public class FuncionarioMap : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("tb_Funcionario");

            builder.HasKey(f => f.Id);

            builder.Property(f => f.NomeFuncionario)
                .HasColumnType("NVARCHAR(50)")
                .IsRequired();

            builder.Property(f => f.EmailCorporativo)
                .HasColumnType("NVARCHAR(50)")
                .IsRequired();

            builder.Property(f => f.Cpf)
                .HasColumnType("NVARCHAR(11)")
                .IsRequired();

            builder.Property(f => f.Emnpresa)
                .HasColumnType("NVARCHAR(40)")
                .IsRequired();

            builder.Property(f => f.Setor)
                .HasColumnType("NVARCHAR(40)")
                .IsRequired();

            builder.Property(f => f.Ativo)
                .HasColumnType("INT")
                .IsRequired();
        }
    }
}
