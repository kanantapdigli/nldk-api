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
    public class PackageController : ControllerBase
    {
        private readonly IPackageRepository packageRepository;
        public PackageController(IPackageRepository packageRepository)
        {
            this.packageRepository = packageRepository;
        }

        [HttpGet]
        public List<Package> GetAll()
        {
            var packages = packageRepository.GetAll();
            return packages;
        }

        [HttpGet("{id}")]
        public Package Get(int id)
        {
            var package = packageRepository.Get(id);
            return package;
        }

        [HttpPost]
        public void Create(Package package)
        {
            packageRepository.Create(package);
        }

        [HttpPost("{id}")]
        public void Edit(Package package)
        {
            packageRepository.Edit(package);
        }

        [HttpPost("{id}")]
        public void Delete(int id)
        {
            packageRepository.Delete(id);
        }
    }
}
