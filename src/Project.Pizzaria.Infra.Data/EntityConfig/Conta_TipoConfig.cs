using Project.Pizzaria.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.Infra.Data.EntityConfig
{
    public class Conta_TipoConfig : EntityTypeConfiguration<Conta_Tipo>
    {
        public Conta_TipoConfig()
        {
            ToTable("conta_tipo");

            Property(ct => ct.Descricao).IsRequired().HasMaxLength(100);

        }
    }
}
