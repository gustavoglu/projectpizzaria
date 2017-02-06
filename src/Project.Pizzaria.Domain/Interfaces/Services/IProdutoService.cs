using Project.Pizzaria.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.Domain.Interfaces.Services
{
    public interface IProdutoService : IDisposable
    {
        Produto Add(Produto produto);

        Produto GetById(Guid Id);

        Produto Update(Produto produto);

        Produto Activate(Produto produto);

        void Remove(Produto produto);

        Produto Disable(Produto produto);

        Produto ReturnEntityDeleted(Produto produto);
   
    }
}
