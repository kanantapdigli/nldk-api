using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KodElan_Api.Models
{
    public class Company
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        public string About { get; set; }

        [NotMapped]
        public IFormFile Logo { get; set; }
        public string LogoName { get; set; }
    }
}
