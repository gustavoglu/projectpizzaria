using System;

namespace Project.Pizzaria.Domain.Models
{
    public class Venda_Pagamento
    {
        public Guid Id_venda_pagamento { get; set; }

        public Guid Id_venda { get; set; }

        public Guid id_pagamento { get; set; }

        public Venda Venda { get; set; }

        public Pagamento Pagamento { get; set; }

    }
}
