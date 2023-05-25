using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgarAparicio.Cities.Manager.Entities
{
    public class City : BaseEntity
    {
        public City(string name)
        {
            Name = name;
        }
        public ICollection<PointOfInterest> PointsOfInterest { get; set; } = new List<PointOfInterest>();

    }
}
