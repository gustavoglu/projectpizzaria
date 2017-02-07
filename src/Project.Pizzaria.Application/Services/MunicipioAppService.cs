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
    class MunicipioAppService : IMunicipioAppService
    {
        protected readonly IMunicipioRepository _municipioRepository;

        public MunicipioAppService()
        {
            _municipioRepository = new MunicipioRepository();
        }

        public MunicipioViewModel Activate(MunicipioViewModel municipioViewModel)
        {
            _municipioRepository.Activate(Mapper.Map<Municipio>(municipioViewModel));

            return municipioViewModel;
        }

        public MunicipioViewModel Add(MunicipioViewModel municipioViewModel)
        {
            _municipioRepository.Add(Mapper.Map<Municipio>(municipioViewModel));

            return municipioViewModel;
        }

        public MunicipioViewModel Disable(MunicipioViewModel municipioViewModel)
        {
            _municipioRepository.Disable(Mapper.Map<Municipio>(municipioViewModel));

            return municipioViewModel;
        }

        public IEnumerable<MunicipioViewModel> GetAllActives()
        {
            return Mapper.Map<IEnumerable<MunicipioViewModel>>(_municipioRepository.GetAllActives());
        }

        public MunicipioViewModel GetById(Guid id)
        {
            return Mapper.Map<MunicipioViewModel>(_municipioRepository.GetById(id));
        }

        public int Remove(MunicipioViewModel municipioViewModel)
        {
            return _municipioRepository.Remove(Mapper.Map<Municipio>(municipioViewModel));
        }

        public MunicipioViewModel Update(MunicipioViewModel municipioViewModel)
        {

            _municipioRepository.Update(Mapper.Map<Municipio>(municipioViewModel));

            return municipioViewModel;
        }
        public void Dispose()
        {
            _municipioRepository.Dispose();
        }

    }
}
