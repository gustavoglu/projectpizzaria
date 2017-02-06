using System;
using System.Collections.Generic;


namespace Project.Pizzaria.Domain.Models
{
    public class Pagamento_Tipo
    {
        public Guid Id_pagamento_tipo { get; set; }

        public Guid Id_pagamento { get; set; }

        public string Descricao { get; set; }

        public virtual ICollection<Pagamento> Pagamentos { get; set; }
    }
}
