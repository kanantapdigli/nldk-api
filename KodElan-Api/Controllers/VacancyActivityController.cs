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
    public class VacancyActivityController : ControllerBase
    {
        private readonly IVacancyActivityRepository vacancyActivityRepository;
        public VacancyActivityController(IVacancyActivityRepository vacancyActivityRepository)
        {
            this.vacancyActivityRepository = vacancyActivityRepository;
        }

        [HttpGet("{id}")]
        public VacancyActivity Get(int id)
        {
            var vacancyActivity = vacancyActivityRepository.Get(id);
            return vacancyActivity;
        }

        [HttpPost]
        public void Create(VacancyActivity vacancyActivity)
        {
            vacancyActivityRepository.Create(vacancyActivity);
        }

        [HttpPost("{id}")]
        public void Edit(VacancyActivity vacancyActivity)
        {
            vacancyActivityRepository.Edit(vacancyActivity);
        }
    }
}
