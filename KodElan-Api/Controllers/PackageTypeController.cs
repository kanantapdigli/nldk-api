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
    public class PackageTypeController : ControllerBase
    {
        private readonly IPackageTypeRepository packageTypeRepository;
        public PackageTypeController(IPackageTypeRepository packageTypeRepository)
        {
            this.packageTypeRepository = packageTypeRepository;
        }

        [HttpGet]
        public List<PackageType> GetAll()
        {
            var packageTypes = packageTypeRepository.GetAll();
            return packageTypes;
        }

        [HttpGet("{id}")]
        public PackageType Get(int id)
        {
            var packageType = packageTypeRepository.Get(id);
            return packageType;
        }

        [HttpPost]
        public void Create(PackageType packageType)
        {
            packageTypeRepository.Create(packageType);
        }

        [HttpPost("{id}")]
        public void Edit(PackageType packageType)
        {
            packageTypeRepository.Edit(packageType);
        }

        [HttpPost("{id}")]
        public void Delete(int id)
        {
            packageTypeRepository.Delete(id);
        }
    }
}
