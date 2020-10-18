using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KodElan_Api.Models
{
    public class Package
    {
        public int Id { get; set; }

        public PackageType PackageType { get; set; }

        [Required]
        public int PackageTypeId { get; set; }

        [Required]
        [StringLength(2)]
        public int Day { get; set; }

        [Required]
        [StringLength(20)]
        public int Price { get; set; }
    }
}
