using AutoMapper;
using ProjetoModelo.MVC.ViewModels;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModelo.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappingProfile"; }
        }
        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();

        }
    }
}