using e_tuition2021.Areas.Identity.Data;
using e_tuition2021.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace e_tuition2021.Data
{
    public class TuitionContext : IdentityDbContext<TuitionUser>
    {
        public TuitionContext(DbContextOptions<TuitionContext> options)
            : base(options)
        {
        }
        public DbSet<Person> People { get; set; }

        public DbSet<Staff> Staff { get; set; }

        public DbSet<Tutor> Tutors { get; set; }

        public DbSet<TimeSlot> TimeSlot { get; set; }

        public DbSet<Lesson> Lessons { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}