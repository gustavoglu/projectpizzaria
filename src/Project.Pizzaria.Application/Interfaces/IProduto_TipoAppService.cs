using Project.Pizzaria.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.Application.Interfaces
{
    public interface IProduto_TipoAppService : IDisposable
    {
        Produto_TipoViewModel Add(Produto_TipoViewModel produto_TipoViewModel);

        Produto_TipoViewModel GetById(Guid id);

        Produto_TipoViewModel Update(Produto_TipoViewModel produto_TipoViewModel);

        Produto_TipoViewModel Activate(Produto_TipoViewModel produto_TipoViewModel);

        Produto_TipoViewModel Disable(Produto_TipoViewModel produto_TipoViewModel);

        IEnumerable<Produto_TipoViewModel> GetAllActives();

        int Remove(Produto_TipoViewModel bairroViewModel);
    }
}
