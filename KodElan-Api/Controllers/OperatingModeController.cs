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
    public class OperatingModeController : ControllerBase
    {
        private readonly IOperatingModeRepository operatingModeRepository;
        public OperatingModeController(IOperatingModeRepository operatingModeRepository)
        {
            this.operatingModeRepository = operatingModeRepository;
        }

        [HttpGet]
        public List<OperatingMode> GetAll()
        {
            var operatingModes = operatingModeRepository.GetAll();
            return operatingModes;
        }

        [HttpGet("{id}")]
        public OperatingMode Get(int id)
        {
            var operatingMode = operatingModeRepository.Get(id);
            return operatingMode;
        }

        [HttpPost]
        public void Create(OperatingMode operatingMode)
        {
            operatingModeRepository.Create(operatingMode);
        }

        [HttpPost("{id}")]
        public void Edit(OperatingMode operatingMode)
        {
            operatingModeRepository.Edit(operatingMode);
        }

        [HttpPost("{id}")]
        public void Delete(int id)
        {
            operatingModeRepository.Delete(id);
        }
    }
}
