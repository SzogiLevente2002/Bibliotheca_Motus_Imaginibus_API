using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bibliotheca_Motus_Imaginibus_API.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false),
                    FirstName = table.Column<string>(type: "longtext", nullable: false),
                    LastName = table.Column<string>(type: "longtext", nullable: false),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Watchlists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Watchlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Watchlists_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: false),
                    Director = table.Column<string>(type: "longtext", nullable: true),
                    ReleasedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Genre = table.Column<string>(type: "longtext", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Poster = table.Column<byte[]>(type: "longblob", nullable: true),
                    WatchlistId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Watchlists_WatchlistId",
                        column: x => x.WatchlistId,
                        principalTable: "Watchlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    RatingNumber = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false),
                    Comment = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "user-role-id", null, "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "user1", 0, "84ab4ef6-4e7c-4307-af9b-09a34512a408", "user1@example.com", true, "John", "Doe", false, null, "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEE2elaaJaCcrH/FYCpVU2MW9QQZ6ixTL8d6HKkwphEHqrT46QmU/ZKt0Yh9kvWEy8w==", null, false, "51404320-cc66-4357-be84-93291ba420a7", false, "user1" },
                    { "user2", 0, "750bb32f-7320-4dab-89b0-a8a25f0abc1c", "user2@example.com", true, "Jane", "Smith", false, null, "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAECBJpIGPLJ6NBRJuP4lqBXGybEPgNxAJr8gHGsTsCA8utLk4S1yUVQSZGLp9p5Boyw==", null, false, "85948b41-49d2-406e-8ec6-80e4d3c5cfe3", false, "user2" },
                    { "user3", 0, "17899ab4-c7ae-428f-8fc0-a55de9e6b699", "user3@example.com", true, "Alice", "Johnson", false, null, "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEKqEOe8I3bKFkkUUTYzneAHfziELuPU0Y0/sDMXxQYMKT/FUMdH6kCRAAM+/hwFJZw==", null, false, "7cfb51f6-215c-4829-b6e8-d773b2817057", false, "user3" },
                    { "user4", 0, "e94fb7ea-cd59-4e35-8cba-94da70088beb", "user4@example.com", true, "Bob", "Brown", false, null, "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEM0PKkWePo5D/fDdFEzhLRfu/OCcS5877WFaiqYgMQiOckwUcmqwznUcMCUS3y6Cuw==", null, false, "18ca57f4-ac30-4652-a2e9-8649f8ad2c38", false, "user4" },
                    { "user5", 0, "3d42f503-ebd1-470f-b97c-ef5c098953e9", "user5@example.com", true, "Charlie", "Davis", false, null, "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEBpWfhmfO3yrbNYT8kGPH0JbaKFsRoex2EvpXbhSZ9ap2OfUZscPxK3xcCMuSnY4LA==", null, false, "18a29992-13cd-4f73-aa18-0c198a43b2d9", false, "user5" },
                    { "user6", 0, "5cc9ca41-b4a8-4d18-bab7-c4ce10f77e90", "user6@example.com", true, "Emily", "Wilson", false, null, "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEIYFJN19KjacF+LxQsiHRCfU9xUlBDJAQ6VL8hj+VdP233S8SRzVQxc4gYjksh2lUA==", null, false, "2f509f3c-684c-42a0-b9f7-c9779d1c42be", false, "user6" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Genre", "Length", "Poster", "ReleasedDate", "Title", "WatchlistId" },
                values: new object[,]
                {
                    { 1, null, "Action", 137, null, new DateTime(1991, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terminator 2", null },
                    { 2, null, "Sci-Fi", 148, null, new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Inception", null },
                    { 3, null, "Sci-Fi", 136, null, new DateTime(1999, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Matrix", null },
                    { 4, null, "Crime", 175, null, new DateTime(1972, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Godfather", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "user-role-id", "user1" },
                    { "user-role-id", "user2" },
                    { "user-role-id", "user3" },
                    { "user-role-id", "user4" },
                    { "user-role-id", "user5" },
                    { "user-role-id", "user6" }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Comment", "MovieId", "RatingNumber", "UserId" },
                values: new object[,]
                {
                    { 1, "Amazing action, great storyline!", 1, 4.5m, "user1" },
                    { 2, "A classic, but a bit outdated.", 1, 4.0m, "user2" },
                    { 3, "Mind-blowing movie, loved the concept!", 2, 5.0m, "user3" },
                    { 4, "Brilliant, but hard to follow at times.", 2, 4.7m, "user4" },
                    { 5, "A masterpiece of cinema.", 3, 5.0m, "user1" },
                    { 6, "Incredible visuals and action scenes!", 3, 4.8m, "user5" },
                    { 7, "One of the greatest films ever made.", 4, 5.0m, "user6" },
                    { 8, "Amazing storytelling and acting.", 4, 4.9m, "user2" }
                });

            migrationBuilder.InsertData(
                table: "Watchlists",
                columns: new[] { "Id", "AddedDate", "MovieId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 16, 9, 15, 10, 369, DateTimeKind.Local).AddTicks(834), 1, "user1" },
                    { 2, new DateTime(2024, 11, 21, 9, 15, 10, 369, DateTimeKind.Local).AddTicks(912), 3, "user1" },
                    { 3, new DateTime(2024, 11, 11, 9, 15, 10, 369, DateTimeKind.Local).AddTicks(915), 2, "user2" },
                    { 4, new DateTime(2024, 11, 6, 9, 15, 10, 369, DateTimeKind.Local).AddTicks(917), 4, "user3" },
                    { 5, new DateTime(2024, 11, 1, 9, 15, 10, 369, DateTimeKind.Local).AddTicks(919), 1, "user4" },
                    { 6, new DateTime(2024, 10, 27, 9, 15, 10, 369, DateTimeKind.Local).AddTicks(921), 2, "user5" },
                    { 7, new DateTime(2024, 10, 22, 9, 15, 10, 369, DateTimeKind.Local).AddTicks(952), 4, "user6" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_WatchlistId",
                table: "Movies",
                column: "WatchlistId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_MovieId",
                table: "Ratings",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Watchlists_UserId",
                table: "Watchlists",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Watchlists");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
