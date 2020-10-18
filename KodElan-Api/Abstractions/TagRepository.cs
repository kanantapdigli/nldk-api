using KodElan_Api.Contexts;
using KodElan_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KodElan_Api.Abstractions
{
    public class TagRepository : GeneralRepository<Tag>, ITagRepository
    {
        private readonly KodElanContext db;

        public TagRepository(KodElanContext db):base(db)
        {
            this.db = db;
        }

        public List<Vacancy> GetVacancies(int dutyId)
        {
           var vacancies = db.Vacancies.Where(v => v.DutyId == dutyId).ToList();
           return vacancies;
        }
    }
}
