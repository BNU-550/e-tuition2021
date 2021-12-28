using e_tuition2021.Areas.Identity.Data;
using e_tuition2021.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace e_tuition2021.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Person> People { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Staff> Staffs { get; set; }

        public DbSet<Tutor> Tutors { get; set; }

        public DbSet<TimeSlot> TimeSlots { get; set; }

        public DbSet<Lesson> Lessons { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<PaymentCard> PaymentCards { get; set; }
        
    }
}