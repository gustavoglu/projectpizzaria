using System;
using System.Collections.Generic;


namespace Project.Pizzaria.Domain.Models
{
    public class Mesa
    {
        public Guid Id_mesa { get; set; }

        public string Descricao { get; set; }

        public int Numero { get; set; }

        public bool Ativa { get; set; }

        public int Capacidade { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }

    }
}
