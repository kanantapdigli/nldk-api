using KodElan_Api.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KodElan_Api.Abstractions
{
    public class GeneralRepository<T> : IGeneralRepository<T> where T : class
    {
        private readonly KodElanContext db;
        private readonly DbSet<T> dbTable;

        public GeneralRepository(KodElanContext db)
        {
            this.db = db;
            dbTable = db.Set<T>();
        }

        public void Create(T data)
        {
            dbTable.Add(data);
            Save();
        }

        public void Delete(int id)
        {
            var data = dbTable.Find(id);
            dbTable.Remove(data);
            Save();
        }

        public void Edit(T data)
        {
            dbTable.Attach(data);
            db.Entry(data).State = EntityState.Modified;
            Save();
        }

        public T Get(int id)
        {
            var data = dbTable.Find(id);
            return data;
        }

        public List<T> GetAll()
        {
            return dbTable.ToList();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
