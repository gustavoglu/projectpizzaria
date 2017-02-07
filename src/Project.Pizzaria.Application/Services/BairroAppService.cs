using Project.Pizzaria.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Pizzaria.Application.ViewModels;
using AutoMapper;
using Project.Pizzaria.Domain.Interfaces.Repository;
using Project.Pizzaria.Infra.Data.Repository;
using Project.Pizzaria.Domain.Models;

namespace Project.Pizzaria.Application.Services
{
    public class BairroAppService : IBairroAppService
    {
        private readonly IBairroRepository _bairroRepository;

        public BairroAppService()
        {
            _bairroRepository = new BairroRepository();
        }

        public BairroViewModel Activate(BairroViewModel bairroViewModel)
        {
             _bairroRepository.Activate(Mapper.Map<Bairro>(bairroViewModel));
            return bairroViewModel;
        }

        public BairroViewModel Add(BairroViewModel bairroViewModel)
        {
            _bairroRepository.Add(Mapper.Map<Bairro>(bairroViewModel));

            return bairroViewModel;
        }

        public BairroViewModel Disable(BairroViewModel bairroViewModel)
        {
            _bairroRepository.Disable(Mapper.Map<Bairro>(bairroViewModel));
            return bairroViewModel;
        }

        public void Dispose()
        {
            _bairroRepository.Dispose();
        }

        public IEnumerable<BairroViewModel> GetAllActives()
        {
            return Mapper.Map<IEnumerable<BairroViewModel>>(_bairroRepository.GetAllActives());
        }

        public BairroViewModel GetById(Guid id)
        {
            return Mapper.Map<BairroViewModel>(_bairroRepository.GetById(id));
        }

        public int Remove(BairroViewModel bairroViewModel)
        {
            return _bairroRepository.Remove(Mapper.Map<Bairro>(bairroViewModel));
        }

        public BairroViewModel Update(BairroViewModel bairroViewModel)
        {
            _bairroRepository.Update(Mapper.Map<Bairro>(bairroViewModel));

            return bairroViewModel;
        }
    }
}
