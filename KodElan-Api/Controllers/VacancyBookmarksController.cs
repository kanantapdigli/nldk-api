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
    public class VacancyBookmarksController : ControllerBase
    {
        private readonly IVacancyBookmarksRepository vacancyBookmarksRepository;

        public VacancyBookmarksController(IVacancyBookmarksRepository vacancyBookmarksRepository)
        {
            this.vacancyBookmarksRepository = vacancyBookmarksRepository;
        }

        [HttpGet]
        public List<VacancyBookmarks> GetAll()
        {
            var vacancyBookmarks = vacancyBookmarksRepository.GetAll();
            return vacancyBookmarks;
        }

        [HttpGet("{id}")]
        public VacancyBookmarks Get(int id)
        {
            var vacancyBookmark = vacancyBookmarksRepository.Get(id);
            return vacancyBookmark;
        }

        [HttpPost]
        public void Create(VacancyBookmarks vacancyBookmark)
        {
            vacancyBookmarksRepository.Create(vacancyBookmark);
        }

        [HttpPost("{id}")]
        public void Edit(VacancyBookmarks vacancyBookmark)
        {
            vacancyBookmarksRepository.Edit(vacancyBookmark);
        }

        [HttpPost("{id}")]
        public void Delete(int id)
        {
            vacancyBookmarksRepository.Delete(id);
        }
    }
}
