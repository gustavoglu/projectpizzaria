using System;
using System.Collections.Generic;


namespace Project.Pizzaria.Domain.Models
{
    public class Venda_Produto
    {
        public Guid Id_venda_produto { get; set; }

        public Guid Id_produto { get; set; }

        public Guid Id_venda { get; set; }

        public int Quantidade{ get; set; }

        public double Total{ get; set; }

        public Venda_Produto_Variacao Venda_Produto_Variacao { get; set; }

        public Venda Venda { get; set; }

    }
}
