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
    public class DutyController : ControllerBase
    {
        private readonly IDutyRepository dutyRepository;

        public DutyController(IDutyRepository dutyRepository)
        {
            this.dutyRepository = dutyRepository;
        }

        [HttpGet]
        public List<Duty> GetAll()
        {
            var duties = dutyRepository.GetAll();
            return duties;
        }

        [HttpGet("{id}")]
        public Duty Get(int id)
        {
            var duty = dutyRepository.Get(id);
            return duty;
        }

        public void Create(Duty duty)
        {
            dutyRepository.Create(duty);
        }

        [HttpPost("id")]
        public void Edit(Duty duty)
        {
            dutyRepository.Edit(duty);
        }

        [HttpPost("{id}")]
        public void Delete(int id)
        {
            dutyRepository.Delete(id);
        }
    }
}
