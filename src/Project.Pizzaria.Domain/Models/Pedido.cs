using System;
using System.Collections.Generic;


namespace Project.Pizzaria.Domain.Models
{
    public class Pedido
    {
        public Guid Id_pedido { get; set; }

        public Guid Id_mesa { get; set; }

        public Guid Id_venda { get; set; }

        public int Numero { get; set; }

        public bool Delivery { get; set; }

        public bool ParaViagem { get; set; }

        public virtual ICollection<Venda> Vendas { get; set; }

        public Mesa Mesa { get; set; }
    }
}
