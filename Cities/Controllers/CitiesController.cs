using AutoMapper;
using EdgarAparicio.Cities.Manager.Entities;
using EdgarAparicio.Cities.Manager.Entities.ViewModels;
using EdgarAparicio.Cities.Manager.Interfaces;
using EdgarAparicio.Cities.Manager.Manager;
using EdgarAparicio.Cities.Repository.Migrations;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace Cities.Controllers
{
    //Este atributo forazara el uso de enrutamiento basado en atributos que es la mejor practica para crear API
    [ApiController]
    //Todas las URL que se dirigen a este controlador comenzara con API/Cities
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        private readonly ICityManager _cityManager;
        private readonly IMapper _mapper;

        // private readonly ICityManager 
        public CitiesController(ICityManager cityManager,
            IMapper mapper)
        {
            _cityManager = cityManager;
            _mapper = mapper;
        }

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<CityWithoutPointsOfInterest>>> GetCities()
        //{
        //    var cityEntities = await _cityManager.GetCitiesAsync();

        //    var results = new List<CityWithoutPointsOfInterest>();
        //    foreach (var cityEntity in cityEntities)
        //    {
        //        results.Add(new CityWithoutPointsOfInterest
        //        {
        //            Id = cityEntity.Id,
        //            Name = cityEntity.Name,
        //            Description = cityEntity.Description

        //        });
        //    }

        //    return Ok(results);
        //}

        //[HttpGet("GetCitiesWithoutPointsOfInterestAutoMapper")]
        //Postman => https://localhost:7099/api/cities/GetCitiesWithoutPointsOfInterestAutoMapper
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CityWithoutPointsOfInterest>>> GetCitiesWithoutPointsOfInterestAutoMapper()
        {
            var citiesEntities = await _cityManager.GetCitiesAsync();
            return Ok(_mapper.Map<IEnumerable<CityWithoutPointsOfInterest>>(citiesEntities));
        }

        [HttpGet("{id}")]

        //De esta forma el request en postman seria asi 
        //Sin puntos de interes https://localhost:7099/api/cities/2 
        //Con puntos de interes https://localhost:7099/api/cities/2?includePointsOfInterest=true
        //[HttpGet("GetCityAutoMapper")]
        //[Route("{id}")]

        public async Task<ActionResult<CityViewModel>> GetCityAutoMapper(int id, bool includePointsOfInterest = false)
        {
            var city = await _cityManager.GetCityAsync(id, includePointsOfInterest);
            if(city == null)
            {
                return NotFound();
            }
            if (includePointsOfInterest)
            {
                return Ok(_mapper.Map<CityViewModel>(city));
            }
            return Ok(_mapper.Map<CityWithoutPointsOfInterestViewModel>(city));

        }




        
    }
}
