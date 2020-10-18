using KodElan_Api.Contexts;
using KodElan_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KodElan_Api.Abstractions
{
    public class EducationRepository : GeneralRepository<Education>, IEducationRepository
    {
        private readonly KodElanContext db;

        public EducationRepository(KodElanContext db): base(db)
        {
            this.db = db;
        }
    }
}
