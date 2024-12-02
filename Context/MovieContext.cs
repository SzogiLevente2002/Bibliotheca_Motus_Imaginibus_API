using Bibliotheca_Motus_Imaginibus_API.Entities;
using Microsoft.AspNetCore.Identity;
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

        //public DbSet<Actor> Actors { get; set; }
        //public DbSet<MovieActor> MovieActors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //// A MovieActor entitás kulcsainak meghatározása
            //modelBuilder.Entity<MovieActor>()
            //    .HasKey(ma => new { ma.MovieId, ma.ActorId });

            //// Kapcsolatok beállítása a MovieActor entitásban
            //modelBuilder.Entity<MovieActor>()
            //    .HasOne(ma => ma.Movie)
            //    .WithMany(m => m.MovieActors)
            //    .HasForeignKey(ma => ma.MovieId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<MovieActor>()
            //    .HasOne(ma => ma.Actor)
            //    .WithMany(a => a.Movies)
            //    .HasForeignKey(ma => ma.ActorId)
            //    .OnDelete(DeleteBehavior.Cascade); // Ha egy szereplőt törlünk, akkor a kapcsolódó filmek is törlődnek

            //// Movie entitás konfigurációja
            //modelBuilder.Entity<Movie>()
            //    .HasMany(m => m.MovieActors)
            //    .WithOne(ma => ma.Movie)
            //    .HasForeignKey(ma => ma.MovieId)
            //    .OnDelete(DeleteBehavior.Cascade);
            //// Actor entitás konfigurációja
            //modelBuilder.Entity<Actor>()
            //    .HasMany(a => a.Movies)
            //    .WithOne(ma => ma.Actor)
            //    .HasForeignKey(ma => ma.ActorId)
            //    .OnDelete(DeleteBehavior.Cascade); // Az Actor entitásnál a szereplő törlésével a kapcsolódó filmek is törlődnek

            // A Ratings entitás konfigurálása
            modelBuilder.Entity<Ratings>()
                .HasKey(r => r.Id); // Egyedi azonosító a Ratings entitás számára

            modelBuilder.Entity<Ratings>()
                .HasOne(r => r.Movie)
                .WithMany(m => m.Ratings)
                .HasForeignKey(r => r.MovieId)
                .OnDelete(DeleteBehavior.Cascade); // A Rating törlésénél a hozzá kapcsolódó Movie is törlődik
            modelBuilder.Entity<Ratings>()
                .HasOne(r => r.User)
                .WithMany(u => u.Ratings)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade); // A Rating törlésénél a hozzá kapcsolódó User is törlődik

            // Watchlist entitás konfigurációja
            modelBuilder.Entity<Watchlist>()
                .HasKey(w => w.Id); // Egyedi azonosító a Watchlist entitás számára

            modelBuilder.Entity<Watchlist>()
                .HasOne(w => w.User)
                .WithMany(u => u.Watchlists)
                .HasForeignKey(w => w.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Watchlist>()
                .HasMany(w => w.Movies)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            // Alapértelmezett szerep létrehozása
            var userRole = new IdentityRole
            {
                Id = "user-role-id",
                Name = "User",
                NormalizedName = "USER"
            };
            modelBuilder.Entity<IdentityRole>().HasData(userRole);

            // Felhasználók létrehozása
            var passwordHasher = new PasswordHasher<User>();

            var user1 = new User
            {
                Id = "user1", // Egyedi ID
                UserName = "user1",
                NormalizedUserName = "USER1",
                Email = "user1@example.com",
                NormalizedEmail = "USER1@EXAMPLE.COM",
                EmailConfirmed = true,
                FirstName = "John",
                LastName = "Doe"
            };
            user1.PasswordHash = passwordHasher.HashPassword(user1, "Password123!");

            var user2 = new User
            {
                Id = "user2", // Egyedi ID
                UserName = "user2",
                NormalizedUserName = "USER2",
                Email = "user2@example.com",
                NormalizedEmail = "USER2@EXAMPLE.COM",
                EmailConfirmed = true,
                FirstName = "Jane",
                LastName = "Smith"
            };
            user2.PasswordHash = passwordHasher.HashPassword(user2, "Password123!");

            var user3 = new User
            {
                Id = "user3", // Egyedi ID
                UserName = "user3",
                NormalizedUserName = "USER3",
                Email = "user3@example.com",
                NormalizedEmail = "USER3@EXAMPLE.COM",
                EmailConfirmed = true,
                FirstName = "Alice",
                LastName = "Johnson"
            };
            user3.PasswordHash = passwordHasher.HashPassword(user3, "Password123!");

            var user4 = new User
            {
                Id = "user4", // Egyedi ID
                UserName = "user4",
                NormalizedUserName = "USER4",
                Email = "user4@example.com",
                NormalizedEmail = "USER4@EXAMPLE.COM",
                EmailConfirmed = true,
                FirstName = "Bob",
                LastName = "Brown"
            };
            user4.PasswordHash = passwordHasher.HashPassword(user4, "Password123!");

            var user5 = new User
            {
                Id = "user5", // Egyedi ID
                UserName = "user5",
                NormalizedUserName = "USER5",
                Email = "user5@example.com",
                NormalizedEmail = "USER5@EXAMPLE.COM",
                EmailConfirmed = true,
                FirstName = "Charlie",
                LastName = "Davis"
            };
            user5.PasswordHash = passwordHasher.HashPassword(user5, "Password123!");

            var user6 = new User
            {
                Id = "user6", // Egyedi ID
                UserName = "user6",
                NormalizedUserName = "USER6",
                Email = "user6@example.com",
                NormalizedEmail = "USER6@EXAMPLE.COM",
                EmailConfirmed = true,
                FirstName = "Emily",
                LastName = "Wilson"
            };
            user6.PasswordHash = passwordHasher.HashPassword(user6, "Password123!");

            modelBuilder.Entity<User>().HasData(user1, user2, user3, user4, user5, user6);

            // Felhasználó-szerep kapcsolat (minden felhasználó a "User" szerepkörben)
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = "user1", RoleId = "user-role-id" },
                new IdentityUserRole<string> { UserId = "user2", RoleId = "user-role-id" },
                new IdentityUserRole<string> { UserId = "user3", RoleId = "user-role-id" },
                new IdentityUserRole<string> { UserId = "user4", RoleId = "user-role-id" },
                new IdentityUserRole<string> { UserId = "user5", RoleId = "user-role-id" },
                new IdentityUserRole<string> { UserId = "user6", RoleId = "user-role-id" }
            );

            // Egyéb entitás seedelés (ahogy korábban)
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Terminator 2", Director = "James Cameron", ReleasedDate = new DateTime(1991, 8, 16), Genre = "Action", Length = 137 },
                new Movie { Id = 2, Title = "Inception", Director = "Christopher Nolan", ReleasedDate = new DateTime(2010, 7, 16), Genre = "Sci-Fi", Length = 148 },
                new Movie { Id = 3, Title = "The Matrix", Director = "Lana Wachowski", ReleasedDate = new DateTime(1999, 3, 31), Genre = "Sci-Fi", Length = 136 },
                new Movie { Id = 4, Title = "The Godfather", Director = "Francis Ford Coppola", ReleasedDate = new DateTime(1972, 3, 24), Genre = "Crime", Length = 175 }
            );

            modelBuilder.Entity<Ratings>().HasData(
                new Ratings { Id = 1, RatingNumber = 4, MovieId = 1, UserId = "user1", Comment = "Amazing action, great storyline!" },
                new Ratings { Id = 2, RatingNumber = 4, MovieId = 1, UserId = "user2", Comment = "A classic, but a bit outdated." },
                new Ratings { Id = 3, RatingNumber = 5, MovieId = 2, UserId = "user3", Comment = "Mind-blowing movie, loved the concept!" },
                new Ratings { Id = 4, RatingNumber = 4, MovieId = 2, UserId = "user4", Comment = "Brilliant, but hard to follow at times." },
                new Ratings { Id = 5, RatingNumber = 50, MovieId = 3, UserId = "user1", Comment = "A masterpiece of cinema." },
                new Ratings { Id = 6, RatingNumber = 4, MovieId = 3, UserId = "user5", Comment = "Incredible visuals and action scenes!" },
                new Ratings { Id = 7, RatingNumber = 5, MovieId = 4, UserId = "user6", Comment = "One of the greatest films ever made." },
                new Ratings { Id = 8, RatingNumber = 4, MovieId = 4, UserId = "user2", Comment = "Amazing storytelling and acting." }
            );

            // Watchlist adatok seedelése
            modelBuilder.Entity<Watchlist>().HasData(
                new Watchlist { Id = 1, UserId = "user1", MovieId = 1, AddedDate = DateTime.Now.AddDays(-10) },
                new Watchlist { Id = 2, UserId = "user1", MovieId = 3, AddedDate = DateTime.Now.AddDays(-5) },
                new Watchlist { Id = 3, UserId = "user2", MovieId = 2, AddedDate = DateTime.Now.AddDays(-15) },
                new Watchlist { Id = 4, UserId = "user3", MovieId = 4, AddedDate = DateTime.Now.AddDays(-20) },
                new Watchlist { Id = 5, UserId = "user4", MovieId = 1, AddedDate = DateTime.Now.AddDays(-25) },
                new Watchlist { Id = 6, UserId = "user5", MovieId = 2, AddedDate = DateTime.Now.AddDays(-30) },
                new Watchlist { Id = 7, UserId = "user6", MovieId = 4, AddedDate = DateTime.Now.AddDays(-35) }
            );

        }

    }
}