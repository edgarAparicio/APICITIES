using AutoMapper;
using EdgarAparicio.Cities.Manager.Entities.ViewModels;
using EdgarAparicio.Cities.Manager.Entities;

namespace Cities.Profiles
{
    public class BaseProfile : Profile
    {
        public BaseProfile() 
        {
            CreateMap<BaseEntity, BaseViewModel>();
        }    
    }
}
