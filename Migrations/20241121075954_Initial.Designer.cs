﻿// <auto-generated />
using System;
using Bibliotheca_Motus_Imaginibus_API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bibliotheca_Motus_Imaginibus_API.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20241121075954_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Bibliotheca_Motus_Imaginibus_API.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<byte[]>("Poster")
                        .HasColumnType("longblob");

                    b.Property<DateTime>("ReleasedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("WatchlistId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WatchlistId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Genre = "Action",
                            Length = 137,
                            ReleasedDate = new DateTime(1991, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Terminator 2"
                        },
                        new
                        {
                            Id = 2,
                            Genre = "Sci-Fi",
                            Length = 148,
                            ReleasedDate = new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Inception"
                        },
                        new
                        {
                            Id = 3,
                            Genre = "Sci-Fi",
                            Length = 136,
                            ReleasedDate = new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Matrix"
                        },
                        new
                        {
                            Id = 4,
                            Genre = "Crime",
                            Length = 175,
                            ReleasedDate = new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Godfather"
                        });
                });

            modelBuilder.Entity("Bibliotheca_Motus_Imaginibus_API.Entities.Ratings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<decimal>("RatingNumber")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "Amazing action, great storyline!",
                            MovieId = 1,
                            RatingNumber = 4.5m,
                            UserId = "user1"
                        },
                        new
                        {
                            Id = 2,
                            Comment = "A classic, but a bit outdated.",
                            MovieId = 1,
                            RatingNumber = 4.0m,
                            UserId = "user2"
                        },
                        new
                        {
                            Id = 3,
                            Comment = "Mind-blowing movie, loved the concept!",
                            MovieId = 2,
                            RatingNumber = 5.0m,
                            UserId = "user3"
                        },
                        new
                        {
                            Id = 4,
                            Comment = "Brilliant, but hard to follow at times.",
                            MovieId = 2,
                            RatingNumber = 4.7m,
                            UserId = "user4"
                        },
                        new
                        {
                            Id = 5,
                            Comment = "A masterpiece of cinema.",
                            MovieId = 3,
                            RatingNumber = 5.0m,
                            UserId = "user1"
                        },
                        new
                        {
                            Id = 6,
                            Comment = "Incredible visuals and action scenes!",
                            MovieId = 3,
                            RatingNumber = 4.8m,
                            UserId = "user5"
                        },
                        new
                        {
                            Id = 7,
                            Comment = "One of the greatest films ever made.",
                            MovieId = 4,
                            RatingNumber = 5.0m,
                            UserId = "user6"
                        },
                        new
                        {
                            Id = 8,
                            Comment = "Amazing storytelling and acting.",
                            MovieId = 4,
                            RatingNumber = 4.9m,
                            UserId = "user2"
                        });
                });

            modelBuilder.Entity("Bibliotheca_Motus_Imaginibus_API.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "user1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c88d08ae-0225-4952-8505-d2bfc69451b1",
                            Email = "user1@example.com",
                            EmailConfirmed = true,
                            FirstName = "John",
                            LastName = "Doe",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER1@EXAMPLE.COM",
                            NormalizedUserName = "USER1",
                            PasswordHash = "AQAAAAIAAYagAAAAEFeQhR8TD8VY/OXjhC0qbQin8SKxqhQbeIVy55V0Ag4g/P7zqeJhfe1H+A2+yWNpAA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e05ce44c-9355-4f16-ad7f-1fc4a22548b1",
                            TwoFactorEnabled = false,
                            UserName = "user1"
                        },
                        new
                        {
                            Id = "user2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2e6e5161-bddb-4643-97fd-71c95d201dea",
                            Email = "user2@example.com",
                            EmailConfirmed = true,
                            FirstName = "Jane",
                            LastName = "Smith",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER2@EXAMPLE.COM",
                            NormalizedUserName = "USER2",
                            PasswordHash = "AQAAAAIAAYagAAAAELvsjeuyQpg7rTiWBOVruWgGN1TTohnfm3yGFv1ZWSc2bIeYCfzgF7pHe4fWvDulRw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f6c5d375-227a-455f-a1d0-f4f8ebf253e9",
                            TwoFactorEnabled = false,
                            UserName = "user2"
                        },
                        new
                        {
                            Id = "user3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "697b9db7-497c-4de7-b7c9-a64bd5b11a8f",
                            Email = "user3@example.com",
                            EmailConfirmed = true,
                            FirstName = "Alice",
                            LastName = "Johnson",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER3@EXAMPLE.COM",
                            NormalizedUserName = "USER3",
                            PasswordHash = "AQAAAAIAAYagAAAAEEAGW45H4ILQe5dbQBGkOtfWE7XB/bzPiwr21g/CZw/tbPv56z7zlvS4VBsXEPjn+w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1b3d7b7a-74c4-48b5-89fe-8229d99ecd35",
                            TwoFactorEnabled = false,
                            UserName = "user3"
                        },
                        new
                        {
                            Id = "user4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ec6d5c7b-931e-4e55-bc11-5d1ea1b9b8b6",
                            Email = "user4@example.com",
                            EmailConfirmed = true,
                            FirstName = "Bob",
                            LastName = "Brown",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER4@EXAMPLE.COM",
                            NormalizedUserName = "USER4",
                            PasswordHash = "AQAAAAIAAYagAAAAECnRNsWla5IDhpsEltEcH2uFXy3A2aCbShxeWEUtUqQ3cZZyDeRCD2+8zPVGAb/CaA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "05e6c9f8-2b0a-4731-9048-3eaf34983671",
                            TwoFactorEnabled = false,
                            UserName = "user4"
                        },
                        new
                        {
                            Id = "user5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6da900a4-bbce-41f2-b5fc-c7883beebf0f",
                            Email = "user5@example.com",
                            EmailConfirmed = true,
                            FirstName = "Charlie",
                            LastName = "Davis",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER5@EXAMPLE.COM",
                            NormalizedUserName = "USER5",
                            PasswordHash = "AQAAAAIAAYagAAAAEKeqaf51y4ZazkBWmzd9EaTYXcWd9p4Enip5IVlikDdlwVunF3XcSHkQLGDBavFAJA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9386345a-29e3-4c00-986a-a72f7f4b1143",
                            TwoFactorEnabled = false,
                            UserName = "user5"
                        },
                        new
                        {
                            Id = "user6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3de21e64-1cb5-4e91-80d8-88cb895c2303",
                            Email = "user6@example.com",
                            EmailConfirmed = true,
                            FirstName = "Emily",
                            LastName = "Wilson",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER6@EXAMPLE.COM",
                            NormalizedUserName = "USER6",
                            PasswordHash = "AQAAAAIAAYagAAAAEGixdU2tOTGQc1odCSdaFMC/+BIJpJyJySVafSePYksd/bPtUCDa+I3BzGRC3gCTSw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5b65cd82-115e-4c03-8fbc-487559951d7c",
                            TwoFactorEnabled = false,
                            UserName = "user6"
                        });
                });

            modelBuilder.Entity("Bibliotheca_Motus_Imaginibus_API.Entities.Watchlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Watchlists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddedDate = new DateTime(2024, 11, 11, 8, 59, 53, 713, DateTimeKind.Local).AddTicks(7871),
                            MovieId = 1,
                            UserId = "user1"
                        },
                        new
                        {
                            Id = 2,
                            AddedDate = new DateTime(2024, 11, 16, 8, 59, 53, 713, DateTimeKind.Local).AddTicks(7941),
                            MovieId = 3,
                            UserId = "user1"
                        },
                        new
                        {
                            Id = 3,
                            AddedDate = new DateTime(2024, 11, 6, 8, 59, 53, 713, DateTimeKind.Local).AddTicks(7943),
                            MovieId = 2,
                            UserId = "user2"
                        },
                        new
                        {
                            Id = 4,
                            AddedDate = new DateTime(2024, 11, 1, 8, 59, 53, 713, DateTimeKind.Local).AddTicks(7945),
                            MovieId = 4,
                            UserId = "user3"
                        },
                        new
                        {
                            Id = 5,
                            AddedDate = new DateTime(2024, 10, 27, 8, 59, 53, 713, DateTimeKind.Local).AddTicks(7947),
                            MovieId = 1,
                            UserId = "user4"
                        },
                        new
                        {
                            Id = 6,
                            AddedDate = new DateTime(2024, 10, 22, 8, 59, 53, 713, DateTimeKind.Local).AddTicks(7949),
                            MovieId = 2,
                            UserId = "user5"
                        },
                        new
                        {
                            Id = 7,
                            AddedDate = new DateTime(2024, 10, 17, 8, 59, 53, 713, DateTimeKind.Local).AddTicks(7956),
                            MovieId = 4,
                            UserId = "user6"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "user-role-id",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "user1",
                            RoleId = "user-role-id"
                        },
                        new
                        {
                            UserId = "user2",
                            RoleId = "user-role-id"
                        },
                        new
                        {
                            UserId = "user3",
                            RoleId = "user-role-id"
                        },
                        new
                        {
                            UserId = "user4",
                            RoleId = "user-role-id"
                        },
                        new
                        {
                            UserId = "user5",
                            RoleId = "user-role-id"
                        },
                        new
                        {
                            UserId = "user6",
                            RoleId = "user-role-id"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Bibliotheca_Motus_Imaginibus_API.Entities.Movie", b =>
                {
                    b.HasOne("Bibliotheca_Motus_Imaginibus_API.Entities.Watchlist", null)
                        .WithMany("Movies")
                        .HasForeignKey("WatchlistId");
                });

            modelBuilder.Entity("Bibliotheca_Motus_Imaginibus_API.Entities.Ratings", b =>
                {
                    b.HasOne("Bibliotheca_Motus_Imaginibus_API.Entities.Movie", "Movie")
                        .WithMany("Ratings")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bibliotheca_Motus_Imaginibus_API.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bibliotheca_Motus_Imaginibus_API.Entities.Watchlist", b =>
                {
                    b.HasOne("Bibliotheca_Motus_Imaginibus_API.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Bibliotheca_Motus_Imaginibus_API.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Bibliotheca_Motus_Imaginibus_API.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bibliotheca_Motus_Imaginibus_API.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Bibliotheca_Motus_Imaginibus_API.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bibliotheca_Motus_Imaginibus_API.Entities.Movie", b =>
                {
                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("Bibliotheca_Motus_Imaginibus_API.Entities.Watchlist", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}