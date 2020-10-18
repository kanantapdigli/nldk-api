using KodElan_Api.Abstractions;
using KodElan_Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KodElan_Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CVBookmarksController: ControllerBase
    {
        private readonly ICVBookmarksRepository cvBookmarksRepository;

        public CVBookmarksController(ICVBookmarksRepository cvBookmarksRepository)
        {
            this.cvBookmarksRepository = cvBookmarksRepository;
        }

        [HttpGet]
        public List<CVBookmarks> GetAll()
        {
            var cvBookmarks = cvBookmarksRepository.GetAll();
            return cvBookmarks;
        }

        [HttpGet("{id}")]
        public CVBookmarks Get(int id)
        {
            var cvBookmark = cvBookmarksRepository.Get(id);
            return cvBookmark;
        }

        [HttpPost]
        public void Create(CVBookmarks cvBookmark)
        {
            cvBookmarksRepository.Create(cvBookmark);
        }

        [HttpPost("{id}")]
        public void Edit(CVBookmarks cvBookmark)
        {
            cvBookmarksRepository.Edit(cvBookmark);
        }

        [HttpPost("{id}")]
        public void Delete(int id)
        {
            cvBookmarksRepository.Delete(id);
        }
    }
}
