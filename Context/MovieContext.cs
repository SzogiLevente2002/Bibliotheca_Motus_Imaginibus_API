using Bibliotheca_Motus_Imaginibus_API.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bibliotheca_Motus_Imaginibus_API.Context
{
    public class MovieContext : IdentityDbContext<User>
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rating> Ratings { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


        modelBuilder.Entity<Rating>()
            .HasOne(r => r.User)
            .WithMany()  // Azt jelzi, hogy az 'ApplicationUser' nem fog több 'Rating' példányt tartalmazni, ha nem definiálod az invers kapcsolatot.
            .HasForeignKey(r => r.UserId);  // Az idegen kulcs
    }

    }
}
