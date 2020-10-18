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
    public class CVController : ControllerBase
    {
        private readonly ICVRepository cvRepository;

        public CVController(ICVRepository cvRepository)
        {
            this.cvRepository = cvRepository;
        }

        [HttpGet]
        public List<CV> GetAll()
        {
            var cvs = cvRepository.GetAll();
            return cvs;
        }

        [HttpGet("{id}")]
        public CV Get(int id)
        {
            var cv = cvRepository.Get(id);
            return cv;
        }

        public void Create(CV cv)
        {
            cvRepository.Create(cv);
        }

        [HttpPost("id")]
        public void Edit(CV cv)
        {
            cvRepository.Edit(cv);
        }

        [HttpPost("{id}")]
        public void Delete(int id)
        {
            cvRepository.Delete(id);
        }
    }
}
