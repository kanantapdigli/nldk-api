using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KodElan_Api.Models
{
    public class Experience
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Type { get; set; }
    }
}
