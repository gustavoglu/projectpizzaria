using Project.Pizzaria.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Pizzaria.Application.ViewModels;
using Project.Pizzaria.Domain.Interfaces.Repository;
using Project.Pizzaria.Infra.Data.Repository;
using AutoMapper;
using Project.Pizzaria.Domain.Models;

namespace Project.Pizzaria.Application.Services
{
    public class ProdutoAppService : IProdutoAppService
    {
        public readonly IProdutoRepository _produtoRepository;

        public ProdutoAppService()
        {
            _produtoRepository = new ProdutoRepository();
        }

        public ProdutoViewModel Activate(ProdutoViewModel produtoViewModel)
        {
            throw new NotImplementedException();
        }

        public Produto_ProdutoTipoViewModel Add(Produto_ProdutoTipoViewModel produto_ProdutoTipoViewModel)
        {
            var produto = Mapper.Map<Produto>(produto_ProdutoTipoViewModel.ProdutoViewModel);
            var produto_tipo = Mapper.Map<Produto_Tipo>(produto_ProdutoTipoViewModel.Produto_TipoViewModel);

            if (produto_tipo != null)
            {
                produto.Produto_tipo = produto_tipo;
            }

            _produtoRepository.Add(produto);

            return produto_ProdutoTipoViewModel;
        }

        public ProdutoViewModel Disable(ProdutoViewModel produtoViewModel)
        {
           var produto = Mapper.Map<Produto>(produtoViewModel);
            _produtoRepository.Disable(produto);
            return produtoViewModel;
        }

        public IEnumerable<ProdutoViewModel> GetAllActives()
        {
            return Mapper.Map<IEnumerable<ProdutoViewModel>>(_produtoRepository.GetAllActives());
        }

        public ProdutoViewModel GetById(Guid id)
        {
            return Mapper.Map<ProdutoViewModel>(_produtoRepository.GetById(id));
        }

        public int Remove(ProdutoViewModel produtoViewModel)
        {
            return _produtoRepository.Remove(Mapper.Map<Produto>(produtoViewModel));
        }

        public Produto_ProdutoTipoViewModel Update(Produto_ProdutoTipoViewModel produto_ProdutoTipoViewModel)
        {

            var produto = Mapper.Map<Produto>(produto_ProdutoTipoViewModel.ProdutoViewModel);
            var produto_tipo = Mapper.Map<Produto_Tipo>(produto_ProdutoTipoViewModel.Produto_TipoViewModel);

            if (produto_tipo != null)
            {
                produto.Produto_tipo = produto_tipo;
            }

            _produtoRepository.Add(produto);

            return produto_ProdutoTipoViewModel;
        }
        public void Dispose()
        {
            _produtoRepository.Dispose();
        }

    }
}
