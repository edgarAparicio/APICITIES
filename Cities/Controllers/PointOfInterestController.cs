using AutoMapper;
using EdgarAparicio.Cities.Manager.Entities;
using EdgarAparicio.Cities.Manager.Entities.ViewModels;
using EdgarAparicio.Cities.Manager.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cities.Controllers
{
    [ApiController]

    [Route("api/pointsOfInterest")]

    public class PointOfInterestController : ControllerBase
    {
        private readonly IPointOfInterestManager _manager;
        private readonly IMapper _mapper;

        public PointOfInterestController(IPointOfInterestManager manager, IMapper mapper)
        {
            _manager = manager;
            _mapper = mapper;
        }

        [HttpGet("GetPointsOfInterest")]
        public async Task<ActionResult<IEnumerable<PointsOfInterestViewModel>>> GetPointsOfInterestAutoMapper()
        {
            var PointsOfInterestEntity = await _manager.GetPointsOfInterestAsync();
            return Ok(_mapper.Map<IEnumerable<PointsOfInterestViewModel>>(PointsOfInterestEntity));
        }
    }
}
