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
    public class Produto_TipoAppService : IProduto_TipoAppService
    {
        private readonly IProduto_TipoRepository _produto_TipoRepository;

        public Produto_TipoAppService()
        {
            _produto_TipoRepository = new Produto_TipoRepository();  
        }
        public Produto_TipoViewModel Activate(Produto_TipoViewModel produto_TipoViewModel)
        {
            _produto_TipoRepository.Activate(Mapper.Map<Produto_Tipo>(produto_TipoViewModel));

            return produto_TipoViewModel;
        }

        public Produto_TipoViewModel Add(Produto_TipoViewModel produto_TipoViewModel)
        {
            _produto_TipoRepository.Add(Mapper.Map<Produto_Tipo>(produto_TipoViewModel));

            return produto_TipoViewModel;
        }

        public Produto_TipoViewModel Disable(Produto_TipoViewModel produto_TipoViewModel)
        {
            _produto_TipoRepository.Disable(Mapper.Map<Produto_Tipo>(produto_TipoViewModel));

            return produto_TipoViewModel;
        }

        public IEnumerable<Produto_TipoViewModel> GetAllActives()
        {
            return Mapper.Map<IEnumerable<Produto_TipoViewModel>>(_produto_TipoRepository.GetAllActives());
        }

        public Produto_TipoViewModel GetById(Guid id)
        {
            return Mapper.Map<Produto_TipoViewModel>(_produto_TipoRepository.GetById(id));
        }

        public int Remove(Produto_TipoViewModel produto_TipoViewModel)
        {
            return _produto_TipoRepository.Remove(Mapper.Map<Produto_Tipo>(produto_TipoViewModel));
        }

        public Produto_TipoViewModel Update(Produto_TipoViewModel produto_TipoViewModel)
        {
            _produto_TipoRepository.Update(Mapper.Map<Produto_Tipo>(produto_TipoViewModel));

            return produto_TipoViewModel;
        }
        public void Dispose()
        {
            _produto_TipoRepository.Dispose();
        }

    }
}
