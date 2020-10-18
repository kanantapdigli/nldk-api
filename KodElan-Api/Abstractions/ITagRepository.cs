using KodElan_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KodElan_Api.Abstractions
{
    public interface ITagRepository : IGeneralRepository<Tag>
    {
        List<Vacancy> GetVacancies(int dutyId);
    }
}
