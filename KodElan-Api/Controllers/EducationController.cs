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
    public class EducationController : ControllerBase
    {
        private readonly IEducationRepository educationRepository;
        public EducationController(IEducationRepository educationRepository)
        {
            this.educationRepository = educationRepository;
        }

        [HttpGet]
        public List<Education> GetAll()
        {
            var educations = educationRepository.GetAll();
            return educations;
        }

        [HttpGet("{id}")]
        public Education Get(int id)
        {
            var education = educationRepository.Get(id);
            return education;
        }

        [HttpPost]
        public void Create(Education education)
        {
            educationRepository.Create(education);
        }

        [HttpPost("{id}")]
        public void Edit(Education education)
        {
            educationRepository.Edit(education);
        }

        [HttpPost("{id}")]
        public void Delete(int id)
        {
            educationRepository.Delete(id);
        }
    }
}
