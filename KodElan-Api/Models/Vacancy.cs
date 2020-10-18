using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KodElan_Api.Models
{
    public class Vacancy
    {
        public int Id { get; set; }
        public Company Company { get; set; }

        [Required]
        public int CompanyId { get; set; }

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

        [Required]
        public int OperatingModeId { get; set; }
        public Salary MinSalary { get; set; }

        [Required]
        public int MinSalaryId { get; set; }
        public string AboutWork { get; set; }
        public int RequirementsCandidate { get; set; }

        [Required]
        [StringLength(50)]
        public string RelevantPerson { get; set; }

        [Required]
        [StringLength(30)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        public ICollection<VacancyBookmarks> UserVacancyBookmarks { get; set; }
        public DateTime Deadline { get; set; }
    }
}
