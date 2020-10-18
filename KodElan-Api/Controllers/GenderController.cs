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
    public class GenderController : ControllerBase
    {
        private readonly IGenderRepository genderRepository;
        public GenderController(IGenderRepository genderRepository)
        {
            this.genderRepository = genderRepository;
        }

        [HttpGet]
        public List<Gender> GetAll()
        {
            var genders = genderRepository.GetAll();
            return genders;
        }

        [HttpGet("{id}")]
        public Gender Get(int id)
        {
            var gender = genderRepository.Get(id);
            return gender;
        }

        [HttpPost]
        public void Create(Gender gender)
        {
            genderRepository.Create(gender);
        }

        [HttpPost("{id}")]
        public void Edit(Gender gender)
        {
            genderRepository.Edit(gender);
        }

        [HttpPost("{id}")]
        public void Delete(int id)
        {
            genderRepository.Delete(id);
        }
    }
}
