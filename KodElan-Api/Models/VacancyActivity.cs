using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KodElan_Api.Models
{
    public class VacancyActivity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(2)]
        public int Day { get; set; }
    }
}
