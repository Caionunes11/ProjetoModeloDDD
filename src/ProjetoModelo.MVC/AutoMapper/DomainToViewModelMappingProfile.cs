using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModelo.MVC.ViewModels;
using ProjetoModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoModelo.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }
        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();

        }


    }
}