using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KodElan_Api.Models
{
    public class CVBookmarks
    {
        public User User { get; set; }

        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; }

        public CV CV { get; set; }

        [Required]
        [ForeignKey("CV")]
        public int CVId { get; set; }
    }
}
