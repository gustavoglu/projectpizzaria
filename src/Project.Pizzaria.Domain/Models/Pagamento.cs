

using System;

namespace Project.Pizzaria.Domain.Models
{
    public class Pagamento
    {
        public Guid id_pagamento_tipo;

        public Guid Id_pagamento { get; set; }

        public double Valor { get; set; }

        public double Troco { get; set; }

        public Pagamento_Tipo Pagamento_tipo { get; set; }

    }

}
