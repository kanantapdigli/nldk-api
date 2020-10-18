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
    public class SalaryController : ControllerBase
    {
        private readonly ISalaryRepository salaryRepository;
        public SalaryController(ISalaryRepository salaryRepository)
        {
            this.salaryRepository = salaryRepository;
        }

        [HttpGet]
        public List<Salary> GetAll()
        {
            var salaries = salaryRepository.GetAll();
            return salaries;
        }

        [HttpGet("{id}")]
        public Salary Get(int id)
        {
            var salary = salaryRepository.Get(id);
            return salary;
        }

        [HttpPost]
        public void Create(Salary salary)
        {
            salaryRepository.Create(salary);
        }

        [HttpPost("{id}")]
        public void Edit(Salary salary)
        {
            salaryRepository.Edit(salary);
        }

        [HttpPost("{id}")]
        public void Delete(int id)
        {
            salaryRepository.Delete(id);
        }
    }
}
