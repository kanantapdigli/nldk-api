using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KodElan_Api.Models
{
    public class VacancyBookmarks
    {

        public User User{ get; set; }

        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; }

        public Vacancy Vacancy { get; set; }

        [Required]
        [ForeignKey("Vacancy")]
        public int VacancyId { get; set; }
    }
}
