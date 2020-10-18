using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace KodElan_Api.Models
{
    public class User : IdentityUser
    {
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(2)]
        public byte Age { get; set; }
        public Gender Gender { get; set; }
        public int GenderId { get; set; }
        public ICollection<CV> CVs { get; set; }
        public ICollection<Vacancy> Vacancies { get; set; }
        public ICollection<Company> Companies { get; set; }
        public ICollection<CVBookmarks> UserCVBookmarks { get; set; }
        public ICollection<VacancyBookmarks> UserVacancyBookmarks { get; set; }
    }
}
