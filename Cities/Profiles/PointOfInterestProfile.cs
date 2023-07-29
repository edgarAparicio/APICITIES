using AutoMapper;
using EdgarAparicio.Cities.Manager.Entities;
using EdgarAparicio.Cities.Manager.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cities.Profiles
{
    public class PointOfInterestProfile : BaseProfile
    {
        public PointOfInterestProfile()
        {
            CreateMap<PointOfInterest, PointsOfInterestViewModel>();
        }
    }
}
