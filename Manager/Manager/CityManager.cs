using EdgarAparicio.Cities.Manager.Entities;
using EdgarAparicio.Cities.Manager.Interfaces;
using EdgarAparicio.Cities.Repository.Interfaces;
using EdgarAparicio.Cities.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgarAparicio.Cities.Manager.Manager
{
    public class CityManager : ICityManager
    {
        private readonly ICityRepository _repository;

        public CityManager(ICityRepository repository)
        {
            _repository = repository;
        }


        public async Task<IEnumerable<City>> GetCitiesAsync()
        {
            return await _repository.GetCitiesAsync();
        }

        public async Task<City?> GetCityAsync(int cityId, bool includePointsOfInterest)
        {
            return await _repository.GetCityAsync(cityId, includePointsOfInterest);
        }

        public async Task<PointOfInterest?> GetPointOfInterestAsync(int cityId, int pointOfInterestId)
        {
            return await _repository.GetPointOfInterestAsync(cityId, pointOfInterestId);
        }

        public async Task<IEnumerable<PointOfInterest>> GetPointOfInterestsAsync(int cityId)
        {
            return await _repository.GetPointOfInterestsAsync(cityId);
        }
    }
}
