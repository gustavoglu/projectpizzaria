using Project.Pizzaria.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.Application.Interfaces
{
    public interface IProdutoAppService : IDisposable
    {
        Produto_ProdutoTipoViewModel Add(Produto_ProdutoTipoViewModel produto_ProdutoTipoViewModel);

        ProdutoViewModel GetById(Guid id);

        Produto_ProdutoTipoViewModel Update(Produto_ProdutoTipoViewModel produto_ProdutoTipoViewModel);

        ProdutoViewModel Activate(ProdutoViewModel produtoViewModel);

        ProdutoViewModel Disable(ProdutoViewModel produtoViewModel);

        IEnumerable<ProdutoViewModel> GetAllActives();

        int Remove(ProdutoViewModel produtoViewModel);
        
    }
}
