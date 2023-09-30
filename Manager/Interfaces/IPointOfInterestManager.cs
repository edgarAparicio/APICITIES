using EdgarAparicio.Cities.Manager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgarAparicio.Cities.Manager.Interfaces
{
    public interface IPointOfInterestManager
    {
        Task<IEnumerable<PointOfInterest>> GetPointsOfInterestAsync();

        Task<PointOfInterest?> GetPointOfInterestAsync(int pointOfInterestId);

    }
}
