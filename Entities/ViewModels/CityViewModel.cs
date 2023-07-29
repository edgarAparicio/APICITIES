using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgarAparicio.Cities.Manager.Entities.ViewModels
{
    public class CityViewModel : BaseViewModel
    {
        public int NumberOfPointsOfInterest 
        {
            get
            {
                return PointsOfInterestViewModel.Count;
            } 
        }
        public ICollection<PointOfInterest> PointsOfInterestViewModel { get; set; } = new List<PointOfInterest>();
    }
}
