using EdgarAparicio.Cities.Manager.Entities;
using EdgarAparicio.Cities.Repository.Context;
using EdgarAparicio.Cities.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgarAparicio.Cities.Repository.Repositories
{
    public class PointOfInterestRepository : IPointOfInterestRepository
    {
        private readonly CitiesContext _context;

        public PointOfInterestRepository(CitiesContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context)); 
        }
        public async Task<IEnumerable<PointOfInterest>> GetPointsOfInterestAsync()
        {
            return await _context.PointsOfInterest.OrderBy(p => p.Name).ToListAsync();
        }
        public async Task<PointOfInterest?> GetPointOfInterestAsync(int pointOfInterestId)
        {
            return await _context.PointsOfInterest.Where(p => p.Id == pointOfInterestId).FirstOrDefaultAsync();
        }

        
    }
}
