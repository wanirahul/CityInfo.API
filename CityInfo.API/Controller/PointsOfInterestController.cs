using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controller
{
  [Route("api/cities")]
  public class PointsOfInterestController : ControllerBase
  {
    [HttpGet("{cityId}/pointofinterest")]
    public IActionResult GetPointOfInterest( int cityId)
    {
      var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

      if (city == null) return NotFound();

      return Ok(city.PointOfInterest);
    }

    [HttpGet("{cityId}/pointofinterest/{id}")]
    public IActionResult GetPointOfInterest(int cityId, int id)
    {
      var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

      if (city == null) return NotFound();

      var pointofinterest = city.PointOfInterest.FirstOrDefault(p => p.Id == id);

      if (pointofinterest == null) return NotFound();

      return Ok(pointofinterest);

    }
  }
}
