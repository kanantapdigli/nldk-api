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
    public class TagController : ControllerBase
    {
        private readonly ITagRepository tagRepository;
        public TagController(ITagRepository tagRepository)
        {
            this.tagRepository = tagRepository;
        }

        [HttpGet]
        public List<Tag> GetAll()
        {
            var tags = tagRepository.GetAll();
            return tags;
        }

        [HttpGet("{id}")]
        public Tag Get(int id)
        {
            var tag = tagRepository.Get(id);
            return tag;
        }

        [HttpPost]
        public void Create(Tag tag)
        {
            tagRepository.Create(tag);
        }

        [HttpPost("{id}")]
        public void Edit(Tag tag)
        {
            tagRepository.Edit(tag);
        }

        [HttpPost("{id}")]
        public void Delete(int id)
        {
            tagRepository.Delete(id);
        }

        [HttpGet]
        public List<Vacancy> GetVacancies(int dutyId)
        {
            var vacancies = tagRepository.GetVacancies(dutyId);
            return vacancies;
        }
    }
}
