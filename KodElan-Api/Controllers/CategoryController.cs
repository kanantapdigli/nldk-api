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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        [HttpGet]
        public List<Category> GetAll()
        {
            var categories = categoryRepository.GetAll();
            return categories;
        } 

        [HttpGet("{id}")]
        public Category Get(int id)
        {
            var category = categoryRepository.Get(id);
            return category;
        }

        [HttpPost]
        public void Create(Category category)
        {
            categoryRepository.Create(category);
        }

        [HttpPost("{id}")]
        public void Edit(Category category)
        {
            categoryRepository.Edit(category);
        }

        [HttpPost("{id}")]
        public void Delete(int id)
        {
            categoryRepository.Delete(id);
        }
    }
}
