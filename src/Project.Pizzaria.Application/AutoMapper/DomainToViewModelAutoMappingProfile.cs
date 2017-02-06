using AutoMapper;
using Project.Pizzaria.Application.ViewModels;
using Project.Pizzaria.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Pizzaria.Application.AutoMapper
{
   public class DomainToViewModelAutoMappingProfile : Profile
    {
        public DomainToViewModelAutoMappingProfile()
        {
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
            CreateMap<Produto_Tipo, Produto_TipoViewModel>().ReverseMap();
            CreateMap<Conta, ContaViewModel>().ReverseMap();
            CreateMap<Conta_Tipo, Conta_TipoViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<Bairro, BairroViewModel>().ReverseMap();
            CreateMap<Uf, UfViewModel>().ReverseMap();
            CreateMap<Municipio, MunicipioViewModel>().ReverseMap();
        }
    }
}
