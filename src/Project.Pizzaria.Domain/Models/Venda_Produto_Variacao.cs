using System;
using System.Collections.Generic;

namespace Project.Pizzaria.Domain.Models
{
   public class Venda_Produto_Variacao
    {
        public Guid Id_venda_produto_variacao { get; set; }
        
        public Guid Id_venda_produto { get; set; }

        public Produto Produto { get; set; }

        public Variacao Variacao { get; set; }

        public Venda Venda { get; set; }

        public virtual ICollection<Venda_Produto> Venda_Produtos { get; set; }

    }
}
