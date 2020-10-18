using KodElan_Api.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KodElan_Api.Contexts
{
    public class KodElanContext : IdentityDbContext
    {
        public KodElanContext(DbContextOptions<KodElanContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CVBookmarks>()
         .HasKey(cb => new { cb.UserId, cb.CVId });
            builder.Entity<CVBookmarks>()
                .HasOne(cb => cb.User)
                .WithMany(u => u.UserCVBookmarks)
                .HasForeignKey(u => u.UserId);
            builder.Entity<CVBookmarks>()
                .HasOne(cb => cb.CV)
                .WithMany(c => c.userCVBookmarks)
                .HasForeignKey(c => c.CVId);

            builder.Entity<VacancyBookmarks>()
       .HasKey(vb => new { vb.UserId, vb.VacancyId });
            builder.Entity<VacancyBookmarks>()
                .HasOne(vb => vb.User)
                .WithMany(u => u.UserVacancyBookmarks)
                .HasForeignKey(u => u.UserId);
            builder.Entity<VacancyBookmarks>()
                .HasOne(vb => vb.Vacancy)
                .WithMany(v => v.UserVacancyBookmarks)
                .HasForeignKey(v => v.VacancyId);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CVBookmarks> CVBookmarks { get; set; }
        public DbSet<CV> CVs { get; set; }
        public DbSet<Duty> Duties { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<OperatingMode> OperatingModes { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<PackageType> PackageTypes { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<VacancyActivity> VacancyActivity { get; set; }
        public DbSet<VacancyBookmarks> VacancyBookmarks { get; set; }
    }
}
