using Project.Pizzaria.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Pizzaria.Domain.Models;
using Project.Pizzaria.Domain.Interfaces.Repository;
using System.Linq.Expressions;

namespace Project.Pizzaria.Domain.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            this._produtoRepository = produtoRepository;
        }

        public Produto Activate(Produto produto)
        {
            return _produtoRepository.Activate(produto);
        }

        public Produto Add(Produto produto)
        {
            return _produtoRepository.Add(produto);
        }

        public Produto Disable(Produto produto)
        {
            return _produtoRepository.Disable(produto);
        }

        public void Dispose()
        {
            _produtoRepository.Dispose();
        }

        public Produto GetById(Guid Id)
        {
            return _produtoRepository.GetById(Id);
        }

        public void Remove(Produto produto)
        {
            _produtoRepository.Remove(produto);
        }

        public Produto ReturnEntityDeleted(Produto produto)
        {
            return _produtoRepository.ReturnEntityDeleted(produto);
        }

        public Produto Update(Produto produto)
        {
            throw new NotImplementedException();
        }
    }
}
