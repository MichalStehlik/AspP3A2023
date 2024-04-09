using ASP08Blogisek.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASP08Blogisek.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var hasher = new PasswordHasher<ApplicationUser>();
            /*
            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.HasData(new IdentityRole<Guid>
                {
                    Id = Guid.Parse("11111111-1111-1111-1111-111111110000"),
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                });
                entity.HasData(new IdentityRole<Guid>
                {
                    Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    Name = "Author",
                    NormalizedName = "AUTHOR"
                });
            });*/
        }
    }
}