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

            // Watchlist kapcsolat felhasználóval
            modelBuilder.Entity<Watchlist>()
                .HasOne(w => w.User)
                .WithMany()  // Nincs szükség arra, hogy a felhasználó több Watchlist-et is tartson, ha nem akarjuk
                .HasForeignKey(w => w.UserId);  // Idegen kulcs a UserId-hoz

            // Seed adat a Movie entitáshoz
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Terminator 2", ReleasedDate = new DateTime(1991, 8, 16), Genre = "Action", Length = 137 },
                new Movie { Id = 2, Title = "Inception", ReleasedDate = new DateTime(2010, 7, 16), Genre = "Sci-Fi", Length = 148 },
                new Movie { Id = 3, Title = "The Matrix", ReleasedDate = new DateTime(1999, 3, 31), Genre = "Sci-Fi", Length = 136 },
                new Movie { Id = 4, Title = "The Godfather", ReleasedDate = new DateTime(1972, 3, 24), Genre = "Crime", Length = 175 }
            );

            //modelBuilder.Entity<Ratings>().HasData(
            //    // Ratings for "Terminator 2"
            //    new Ratings { Id = 1, RatingNumber = 4.5m, MovieId = 1, UserId = "user1", Comment = "Amazing action, great storyline!" },
            //    new Ratings { Id = 2, RatingNumber = 4.0m, MovieId = 1, UserId = "user2", Comment = "A classic, but a bit outdated." },

            //    // Ratings for "Inception"
            //    new Ratings { Id = 3, RatingNumber = 5.0m, MovieId = 2, UserId = "user3", Comment = "Mind-blowing movie, loved the concept!" },
            //    new Ratings { Id = 4, RatingNumber = 4.7m, MovieId = 2, UserId = "user4", Comment = "Brilliant, but hard to follow at times." },

            //    // Ratings for "The Matrix"
            //    new Ratings { Id = 5, RatingNumber = 5.0m, MovieId = 3, UserId = "user1", Comment = "A masterpiece of cinema." },
            //    new Ratings { Id = 6, RatingNumber = 4.8m, MovieId = 3, UserId = "user5", Comment = "Incredible visuals and action scenes!" },

                // Ratings for "The Godfather"
            //    new Ratings { Id = 7, RatingNumber = 5.0m, MovieId = 4, UserId = "user6", Comment = "One of the greatest films ever made." },
            //    new Ratings { Id = 8, RatingNumber = 4.9m, MovieId = 4, UserId = "user2", Comment = "Amazing storytelling and acting." }
            //);

           


        }
    }
}
