using KodElan_Api.Contexts;
using KodElan_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KodElan_Api.Abstractions
{
    public class CategoryRepository : GeneralRepository<Category>, ICategoryRepository
    {
        private readonly KodElanContext db;
        public CategoryRepository(KodElanContext db) : base(db)
        {
            this.db = db;
        }
    }
}
