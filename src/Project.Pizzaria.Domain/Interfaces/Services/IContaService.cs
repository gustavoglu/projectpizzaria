using Project.Pizzaria.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.Domain.Interfaces.Services
{
    public interface IContaService : IDisposable
    {
        Conta Add(Conta produto);
        Conta GetById(Guid Id);
        Conta Update(Conta Conta);
        Conta Activate(Conta Conta);
        Conta Disable(Conta Conta);
        Conta ReturnEntityDeleted(Conta Conta);
        void Remove(Conta Conta);

    }
}
