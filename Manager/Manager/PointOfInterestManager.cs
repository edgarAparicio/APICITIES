using EdgarAparicio.Cities.Manager.Entities;
using EdgarAparicio.Cities.Manager.Interfaces;
using EdgarAparicio.Cities.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgarAparicio.Cities.Manager.Manager
{
    public class PointOfInterestManager : IPointOfInterestManager
    {
        private readonly IPointOfInterestRepository _repository;

        public PointOfInterestManager(IPointOfInterestRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<PointOfInterest>> GetPointsOfInterestAsync()
        {
            return await _repository.GetPointsOfInterestAsync();
        }
        public async Task<PointOfInterest?> GetPointOfInterestAsync(int pointOfInterestId)
        {
            return await _repository.GetPointOfInterestAsync(pointOfInterestId);
        }

       
    }
}
