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
    public class ExperienceController : ControllerBase
    {
        private readonly IExperienceRepository experienceRepository;
        public ExperienceController(IExperienceRepository experienceRepository)
        {
            this.experienceRepository = experienceRepository;
        }

        [HttpGet]
        public List<Experience> GetAll()
        {
            var experiences = experienceRepository.GetAll();
            return experiences;
        }

        [HttpGet("{id}")]
        public Experience Get(int id)
        {
            var experience = experienceRepository.Get(id);
            return experience;
        }

        [HttpPost]
        public void Create(Experience experience)
        {
            experienceRepository.Create(experience);
        }

        [HttpPost("{id}")]
        public void Edit(Experience experience)
        {
            experienceRepository.Edit(experience);
        }

        [HttpPost("{id}")]
        public void Delete(int id)
        {
            experienceRepository.Delete(id);
        }
    }
}
