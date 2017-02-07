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
    public class Conta_TipoAppService : IConta_TipoAppService
    {
        private readonly IConta_TipoRepository _conta_TipoRepository;

        public Conta_TipoAppService()
        {
            _conta_TipoRepository = new Conta_TipoRepository();
        }

        public Conta_TipoViewModel Activate(Conta_TipoViewModel conta_TipoViewModel)
        {
            _conta_TipoRepository.Activate(Mapper.Map<Conta_Tipo>(conta_TipoViewModel));

            return conta_TipoViewModel;
        }

        public Conta_TipoViewModel Add(Conta_TipoViewModel conta_TipoViewModel)
        {
            _conta_TipoRepository.Add(Mapper.Map<Conta_Tipo>(conta_TipoViewModel));

            return conta_TipoViewModel;
        }

        public Conta_TipoViewModel Disable(Conta_TipoViewModel conta_TipoViewModel)
        {
            _conta_TipoRepository.Disable(Mapper.Map<Conta_Tipo>(conta_TipoViewModel));

            return conta_TipoViewModel;
        }

        public IEnumerable<Conta_TipoViewModel> GetAllActives()
        {
            return Mapper.Map<IEnumerable<Conta_TipoViewModel>>(_conta_TipoRepository.GetAllActives());
        }

        public Conta_TipoViewModel GetById(Guid id)
        {
            return Mapper.Map<Conta_TipoViewModel>(_conta_TipoRepository.GetById(id));
        }

        public int Remove(Conta_TipoViewModel conta_TipoViewModel)
        {
            return _conta_TipoRepository.Remove(Mapper.Map<Conta_Tipo>(conta_TipoViewModel));
        }

        public Conta_TipoViewModel Update(Conta_TipoViewModel conta_TipoViewModel)
        {
            var conta_tipo = Mapper.Map<Conta_Tipo>(conta_TipoViewModel);
            return Mapper.Map<Conta_TipoViewModel>(_conta_TipoRepository.Update(conta_tipo));
        }
        public void Dispose()
        {
            _conta_TipoRepository.Dispose();
        }

    }
}
