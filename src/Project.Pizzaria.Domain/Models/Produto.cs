

using EP.IdentityIsolation.Domain.Portable.Entities;
using System;

namespace Project.Pizzaria.Domain.Models
{
   public class Produto : EntityBase
    {

        public Guid Id_produto_tipo { get; set; }

        public string Descricao { get; set; }

        public int Codigo { get; set; }

        public string Observacoes { get; set; }

        public Produto_Tipo Produto_tipo { get; set; }

        public string ImagemUri { get; set; }

        public bool BaixaEstoque { get; set; }

        public bool VenderSemEstoque { get; set; }

        public double Saldo { get; set; }


    }
}
