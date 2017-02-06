using Project.Pizzaria.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.Infra.Data.EntityConfig
{
   public class ContaConfig : EntityTypeConfiguration<Conta>
    {
        public ContaConfig()
        {
            ToTable("conta");

            Property(c => c.Email).IsOptional().HasMaxLength(100);

            Property(c => c.Aniversario).IsOptional();

            Property(c => c.Nome).IsRequired().HasMaxLength(100);

            HasRequired(c => c.Conta_Tipo).WithMany(ct => ct.Contas).HasForeignKey(c => c.Id_Conta_Tipo);

        }
    }
}
