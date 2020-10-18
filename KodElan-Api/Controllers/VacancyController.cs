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
    public class VacancyController : ControllerBase
    {
        private readonly IVacancyRepository vacancyRepository;
        public VacancyController(IVacancyRepository vacancyRepository)
        {
            this.vacancyRepository = vacancyRepository;
        }

        [HttpGet]
        public List<Vacancy> GetAll()
        {
            var vacancies = vacancyRepository.GetAll();
            return vacancies;
        }

        [HttpGet("{id}")]
        public Vacancy Get(int id)
        {
            var vacancy = vacancyRepository.Get(id);
            return vacancy;
        }

        [HttpPost]
        public void Create(Vacancy vacancy)
        {
            vacancyRepository.Create(vacancy);
        }

        [HttpPost("{id}")]
        public void Edit(Vacancy vacancy)
        {
            vacancyRepository.Edit(vacancy);
        }

        [HttpPost("{id}")]
        public void Delete(int id)
        {
            vacancyRepository.Delete(id);
        }
    }
}
