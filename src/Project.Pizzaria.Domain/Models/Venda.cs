using System;
using System.Collections.Generic;


namespace Project.Pizzaria.Domain.Models
{
    public class Venda
    {

        public Guid Id_venda { get; set; }

        public Guid id_pedido;

        public Guid Id_venda_pagamento { get; set; }

        public string Observacoes { get; set; }

        public double DescontoValor { get; set; }

        public double DescontoPerc { get; set; }

        public double Total { get; set; }

        public Venda_Pagamento Venda_pagamento { get; set; }

        public Pedido Pedido{ get; set; }

        public Venda_Produto Venda_produto { get; set; }

    }
}
