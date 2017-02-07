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
    public class UfAppService : IUfAppService
    {
        private readonly IUfRepository _ufrepository;

        public UfAppService()
        {
            _ufrepository = new UfRepository();
        }

        public UfViewModel Activate(UfViewModel ufViewModel)
        {
            _ufrepository.Activate(Mapper.Map<Uf>(ufViewModel));

            return ufViewModel;
        }

        public UfViewModel Add(UfViewModel ufViewModel)
        {
            _ufrepository.Add(Mapper.Map<Uf>(ufViewModel));

            return ufViewModel;
        }

        public UfViewModel Disable(UfViewModel ufViewModel)
        {
            _ufrepository.Disable(Mapper.Map<Uf>(ufViewModel));

            return ufViewModel;
        }

        public IEnumerable<UfViewModel> GetAllActives()
        {
            return Mapper.Map<IEnumerable<UfViewModel>>(_ufrepository.GetAllActives());
        }

        public UfViewModel GetById(Guid id)
        {
            return Mapper.Map<UfViewModel>(_ufrepository.GetById(id));
        }

        public int Remove(UfViewModel ufViewModel)
        {
            return _ufrepository.Remove(Mapper.Map<Uf>(ufViewModel));
        }

        public UfViewModel Update(UfViewModel ufViewModel)
        {
            _ufrepository.Update(Mapper.Map<Uf>(ufViewModel));

            return ufViewModel;
        }

        public void Dispose()
        {
            _ufrepository.Dispose();
        }

    }
}
