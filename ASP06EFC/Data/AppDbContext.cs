using ASP06EFC.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP06EFC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // fluent zápis složitějších věcí
            // seed databáze
            modelBuilder.Entity<Classroom>().HasData(
                 new Classroom { ClassroomId = 1, Name = "1.A" },
                 new Classroom { ClassroomId = 2, Name = "2.A" }
            );
            modelBuilder.Entity<Student>().HasData(
                 new Student { StudentId = 1, FirstName = "Petr", LastName="Kraus", ClassroomId = 1 },
                 new Student { StudentId = 2, FirstName = "Karel", LastName = "Novák", ClassroomId = 1 },
                 new Student { StudentId = 3, FirstName = "Jana", LastName = "Tesař", ClassroomId = 1 }
            );
        }
    }
}

// Add-Migration Initial
// Update-Database
