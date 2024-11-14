using Bibliotheca_Motus_Imaginibus_API.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bibliotheca_Motus_Imaginibus_API.Context
{
    public class MovieContext : IdentityDbContext<User>
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Ratings> Ratings { get; set; }
        public DbSet<Watchlist> Watchlists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Kapcsolat beállítása a Movie és Rating között (egy filmhez több értékelés tartozhat)
            modelBuilder.Entity<Ratings>()
                .HasOne(r => r.Movie)
                .WithMany(m => m.Ratings)
                .HasForeignKey(r => r.MovieId);

            modelBuilder.Entity<Ratings>()
                .HasOne(r => r.User)
                .WithMany()
                .HasForeignKey(r => r.UserId);

            modelBuilder.Entity<Watchlist>()
                .HasOne(w => w.User)
                .WithMany()
                .HasForeignKey(w => w.UserId);

            // Seed adat a Movie entitáshoz
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Terminator 2", ReleasedDate = new DateTime(1991, 8, 16), Genre = "Action", Length = 137 }
            );
        }
    }
}
