using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KodElan_Api.Models
{
    public class CV
    {
        public int Id { get; set; }
        public User User { get; set; }

        [Required]
        public int UserId { get; set; }

        public Category Category { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public Duty Duty { get; set; }

        [Required]
        public int DutyId { get; set; }

        public City City { get; set; }
        public int CityId { get; set; }
        public Education Education { get; set; }
        public int EducationId { get; set; }
        public Experience Experience { get; set; }
        public int ExperienceId { get; set; }
        public OperatingMode OperatingMode { get; set; }
        public int OperatingModeId { get; set; }

        public Salary MinSalary { get; set; }

        [Required]
        public int MinSalaryId { get; set; }

        public string AboutEducation { get; set; }

        public string previousWorks { get; set; }
        public string Skills { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }
        public ICollection<CVBookmarks> userCVBookmarks { get; set; }
    }
}
