using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KodElan_Api.Abstractions;
using KodElan_Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KodElan_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityRepository cityRepository;

        public CityController(ICityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }

        [HttpGet]
        public List<City> GetAll()
        {
            var cities = cityRepository.GetAll();
            return cities;
        }

        [HttpGet("{id}")]
        public City Get(int id)
        {
            var city = cityRepository.Get(id);
            return city;
        }

        public void Create(City city)
        {
            cityRepository.Create(city);
        }

        [HttpPost("id")]
        public void Edit(City city)
        {
            cityRepository.Edit(city);
        }

        [HttpPost("{id}")]
        public void Delete(int id)
        {
            cityRepository.Delete(id);
        }
    }
}
