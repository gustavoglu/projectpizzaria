using Project.Pizzaria.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.Infra.Data.EntityConfig
{
   public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            ToTable("endereco");

            Property(e => e.Numero).IsRequired();

            Property(e => e.Telefone1).IsRequired().HasMaxLength(20);

            Property(e => e.Telefone2).IsOptional().HasMaxLength(20);

            Property(e => e.Rua).IsRequired().HasMaxLength(300);

            Property(e => e.Complemento).IsOptional().HasMaxLength(300);

            HasRequired(e => e.Bairro).WithMany(b => b.Enderecos).HasForeignKey(e => e.Id_Bairro);

            HasRequired(e => e.Municipio).WithMany(m => m.Enderecos).HasForeignKey(e => e.Id_Municipio);

            HasRequired(e => e.Uf).WithMany(u => u.Enderecos).HasForeignKey(e => e.Id_Uf);

            HasRequired(e => e.Conta).WithMany(e => e.Enderecos).HasForeignKey(e => e.Id_Conta);




        }
    }
}
