using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KodElan_Api.Models
{
    public class Salary
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string IntervalAmount { get; set; }
        public int MinAmount { get; set; }
        public int MaxAmount { get; set; }
    }
}
