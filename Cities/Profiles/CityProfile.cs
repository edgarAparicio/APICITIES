using AutoMapper;
using Cities.Controllers;
using EdgarAparicio.Cities.Manager.Entities;
using EdgarAparicio.Cities.Manager.Entities.ViewModels;

namespace Cities.Profiles
{
    public class CityProfile : BaseProfile
    {
        public CityProfile()
        {
            CreateMap<City, CityViewModel>();
            CreateMap<City, CityWithoutPointsOfInterest>();
            CreateMap<City, CityWithoutPointsOfInterestViewModel>();
        }
    }
}
