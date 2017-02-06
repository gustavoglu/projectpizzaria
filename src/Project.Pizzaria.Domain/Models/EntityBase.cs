using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.Domain.Models
{
    public abstract class EntityBase
    {

        public Guid Id { get; set; }

        public DateTime CreateAt{ get; set; }

        public DateTime DeletedAt { get; set; }

        public bool Active { get; set; }

        public bool IsDeleted { get; set; }

        public Guid Id_Company { get; set; }

        public Guid Id_DeletedByUser { get; set; }

        public Guid Id_CreateByUser { get; set; }

        protected EntityBase()
        {
            Id = Guid.NewGuid();
        }

    }
}
