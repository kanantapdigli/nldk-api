using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KodElan_Api.Abstractions;
using KodElan_Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Differencing;

namespace KodElan_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository companyRepository;

        public CompanyController(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }

        [HttpGet]
        public List<Company> GetAll()
        {
            var companies = companyRepository.GetAll();
            return companies;
        }

        [HttpGet("{id}")]
        public Company Get(int id)
        {
            var company = companyRepository.Get(id);
            return company;
        }

        [HttpPost("id")]
        public void Create(Company company)
        {
            companyRepository.Create(company);
        }

        [HttpPost("{id}")]
        public void Edit(Company company)
        {
            companyRepository.Edit(company);
        }

        [HttpPost("{id}")]
        public void Delete(int id)
        {
            companyRepository.Delete(id);
        }
    }
}
