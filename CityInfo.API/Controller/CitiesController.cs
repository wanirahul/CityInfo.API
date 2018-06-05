﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controller
{
  [Route("api/cities")]
  public class CitiesController : ControllerBase
  {
    [HttpGet()]
    public IActionResult GetCities()
    {
      return Ok(CitiesDataStore.Current.Cities);
    }

    [HttpGet("{id}")]
    public IActionResult GetCity(int id)
    {
      var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
      if (city == null) return NotFound();

      return Ok(city);
    }
  }
}
