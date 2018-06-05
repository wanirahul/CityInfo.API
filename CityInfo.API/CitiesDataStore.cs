using CityInfo.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
  public class CitiesDataStore
  {
    // Auto Property initilizer in C# 6
    public static CitiesDataStore Current { get; } = new CitiesDataStore();

    public List<CityDto> Cities { get; set; }

    public CitiesDataStore()
    {
      //init dummy data

      Cities = new List<CityDto>()
      {
        new CityDto()
        {
          Id = 1,
          Name = "New York City",
          Description = "The one of the big park.",
          PointOfInterest = new List<PointOfInterestDto>()
          {
            new PointOfInterestDto() {
              Id = 1,
              Name = "Central Park",
              Description = "The most visited urban park in United States"
            },
            new PointOfInterestDto() {
              Id = 2,
              Name = "Empire State Building",
              Description = "A 102-story skycraper located in Midtown Manhattan"
            }
          }
        },
        new CityDto()
        {
          Id = 2,
          Name = "Mumbai",
          Description = "The one of crowded city.",
          PointOfInterest = new List<PointOfInterestDto>()
          {
            new PointOfInterestDto() {
              Id = 1,
              Name = "Mahalaxmi Mandir",
              Description = "The most visited Mandir in Maharshtra"
            },
            new PointOfInterestDto() {
              Id = 2,
              Name = "Hotel Taj",
              Description = "The Herittage hotel of India"
            }
          }
        },
        new CityDto()
        {
          Id = 3,
          Name = "Dehli",
          Description = "The one of clean city.",
          PointOfInterest = new List<PointOfInterestDto>()
          {
            new PointOfInterestDto() {
              Id = 1,
              Name = "Chandani Chowk",
              Description = "The old city area where people love to buy and eat"
            },
            new PointOfInterestDto() {
              Id = 2,
              Name = "Rashtrapati Bhavan",
              Description = "The House of priesedent"
            }
          }
        }
      };
    }
  }
}
