using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bibliotheca_Motus_Imaginibus_API.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Watchlists_WatchlistId",
                table: "Movies");

            migrationBuilder.DeleteData(
                table: "Watchlists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Watchlists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Watchlists",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Watchlists",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Watchlists",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Watchlists",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Watchlists",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.AddColumn<string>(
                name: "Actor1",
                table: "Movies",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Actor2",
                table: "Movies",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Actor3",
                table: "Movies",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedAt",
                table: "Movies",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Movies",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSeries",
                table: "Movies",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfEpisodes",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfSeasons",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "List<string>",
                columns: table => new
                {
                    Capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb15eb07-7042-4cca-ba6d-4bd740989340", "FirstName1", "LastName1", "AQAAAAIAAYagAAAAECo4iKo8lOxXP+eheeKG7t6z+k68x/5Y9Ya8c5egTxonTpYFbMyBksan4HQL5ovrfA==", "71b753a9-03a7-4ead-a6ac-8fc117622eb8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc603761-5008-4c2f-8268-7ae0671efdbf", "FirstName2", "LastName2", "AQAAAAIAAYagAAAAEDnWBgD7ps0J5oog/hGIJeHxgwklEAzLtTtPjQjsHQ0eMXo1Q7QOq/0mEm/HT3Cu3g==", "15dd1246-491c-417d-a3c8-f2c8d34c4d6a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ac10da7-701e-4154-877c-da114a911931", "FirstName3", "LastName3", "AQAAAAIAAYagAAAAEIKdBMlwPWV6s9Yh6H2qnhe7jd7xGLh/qLExRvSbHRx61t2mOjBnTBIUjHNwxz+CIg==", "08a6879b-871c-4cc8-91f0-1f331db8a054" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b4c72e4-4725-47c4-b633-f3a708cd1471", "FirstName4", "LastName4", "AQAAAAIAAYagAAAAEHpNK70I3szcuR7bfErvugZv0x4yHLIjgNL+Obc/JnFbVyf05aY1AiL9lsqvZUDiNw==", "fe6c0b63-d553-4753-95d2-b0e67b80f529" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61f0f9e4-5039-4ad6-9241-23eb9471bf18", "FirstName5", "LastName5", "AQAAAAIAAYagAAAAEBelBHb9KaZ2fGseng2pOeI9W/6480juGcFDzOsfPxhhV/orxRf93k+j8qW9agpSVA==", "1d326c7c-4c9b-4f5d-88ff-cf0d5cd354db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03c3e1b3-88a9-49a5-b3ec-84b96d05c2e5", "FirstName6", "LastName6", "AQAAAAIAAYagAAAAEOBh7ILgnn242Rxy1e3fHDrOcsuWka13CowBTIrGsEkAA9KOe6LGHR3aYdKySgPoaQ==", "77fe54b4-e415-42e1-82ff-f443f1e8869a" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "user10", 0, "2badd422-e862-4d2d-97c4-f4c172847815", "user10@example.com", true, "FirstName10", "LastName10", false, null, "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEOTxRpbVQMExGgGJX4yWQqpI0BHc/0F9ToW7NZghX6/9H7EKxGTQ6eoUwfT3v+1igg==", null, false, "e6103314-4853-4ef5-a54e-575336122583", false, "user10" },
                    { "user11", 0, "15b9ed15-f0b6-4291-a551-cd9817048ce5", "user11@example.com", true, "FirstName11", "LastName11", false, null, "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEMROMDpG0lUS/ZniOizYQwP+AFEQa/L5GlWpPPdCYceWCwbU5TFNHDAkzWjKwh118A==", null, false, "e3dcec34-a09f-4934-bbfe-e214b2a80dac", false, "user11" },
                    { "user12", 0, "eed66f7d-4997-41ab-b7c8-c72bc8a5d19b", "user12@example.com", true, "FirstName12", "LastName12", false, null, "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEDDC6rY/oHxrqJS/5FnaD/UTVDg7RppdAsrP+VRdwTItegLvZY3jVj7ukvA6ulxABw==", null, false, "520bc434-4268-4f27-9539-d77b9c0b8250", false, "user12" },
                    { "user13", 0, "d6992c59-a608-42b0-8406-3f65fd3b6e4d", "user13@example.com", true, "FirstName13", "LastName13", false, null, "USER13@EXAMPLE.COM", "USER13", "AQAAAAIAAYagAAAAEPeOFzBrMeW2Uoa//iiVYaWp4gglNOeYtexlw9K5uIP9RLMcs1/KEF37B0uDA1C10g==", null, false, "1da61825-af2e-4941-9039-7789c6127603", false, "user13" },
                    { "user14", 0, "a067e8dc-aad3-4af2-bf97-2f761c2c0077", "user14@example.com", true, "FirstName14", "LastName14", false, null, "USER14@EXAMPLE.COM", "USER14", "AQAAAAIAAYagAAAAEOwOK7AgBQZX1ZXnJFJ3ehAcKC+JNYPnAlNfQSMTFI3MKiYgZXJA0FsJTyjtyDmkmw==", null, false, "d5c92eee-bbd2-41a7-b858-a3043cb105cb", false, "user14" },
                    { "user15", 0, "852d9687-6fd4-4799-a689-8f983be66304", "user15@example.com", true, "FirstName15", "LastName15", false, null, "USER15@EXAMPLE.COM", "USER15", "AQAAAAIAAYagAAAAEOdp6leed+lSN8CzVh+GMhualMyFsr3qvaRtYGVBwwFeY4afuP4VrdCKhgH0FUeCkA==", null, false, "9b6efe35-f001-4845-bc3e-d1a8cf3eeb32", false, "user15" },
                    { "user16", 0, "bab937e4-228f-4e5f-889a-5eb7ae8a465b", "user16@example.com", true, "FirstName16", "LastName16", false, null, "USER16@EXAMPLE.COM", "USER16", "AQAAAAIAAYagAAAAEAFEnBP215a05KZEEPl7QQwKy+6YFWmfDsV9SElhUUoe4cmHWrv1ZJTJTMVJGnzjng==", null, false, "4af2d69a-4412-4165-a45f-c10a5fd4f9dd", false, "user16" },
                    { "user17", 0, "af53f37d-b26a-4218-9d6e-2816c9a5fd69", "user17@example.com", true, "FirstName17", "LastName17", false, null, "USER17@EXAMPLE.COM", "USER17", "AQAAAAIAAYagAAAAEJJkSkiRhIk2YeI3VcJxQpjCZOIP8+JB7r/gantpzH/vksi+7w9NZ42LGm5/KZA9LQ==", null, false, "14cf0ba7-434b-4562-94da-d4cb7115d63a", false, "user17" },
                    { "user18", 0, "3d07d0fe-7849-49d0-a81b-8347885fd7da", "user18@example.com", true, "FirstName18", "LastName18", false, null, "USER18@EXAMPLE.COM", "USER18", "AQAAAAIAAYagAAAAEEGhMPa5nTNBc6gsRx71Rx7vRiaWhArhB1YbNBu7oJlaLDIZGncwhwlvuJQ5gG7TLA==", null, false, "336b43b3-2508-4ed9-a1d3-88e133e397e1", false, "user18" },
                    { "user19", 0, "8b8a2731-807f-41ad-a25b-b7aa27a3ba92", "user19@example.com", true, "FirstName19", "LastName19", false, null, "USER19@EXAMPLE.COM", "USER19", "AQAAAAIAAYagAAAAEImiA3w9cF/Z70LbejbsxEPtPCatDkenBlYdWAXlvb+wf4zIVB0YLx0FhsjL2cfFrA==", null, false, "48aa74e3-cc29-4af4-b3bb-d464abfcdb95", false, "user19" },
                    { "user20", 0, "25fd0f5a-18e8-4c80-b872-38cbcae85db4", "user20@example.com", true, "FirstName20", "LastName20", false, null, "USER20@EXAMPLE.COM", "USER20", "AQAAAAIAAYagAAAAEAmstLVWbZHUEm1EpmYyumkUvfA59ZEJWX20lC3BSTr+XqnLJlFP9WGMYFRUJzSbpQ==", null, false, "fb0ad109-faa8-4540-9113-aeabada0144b", false, "user20" },
                    { "user21", 0, "8944e7d3-b359-448e-920b-23929eaac600", "user21@example.com", true, "FirstName21", "LastName21", false, null, "USER21@EXAMPLE.COM", "USER21", "AQAAAAIAAYagAAAAEM1lSvPVhDKC+olSGX1l9HQVj1j6fvFMMMCQhS+fuBC6SG7NvwrwRD6APkChbUcVkQ==", null, false, "1758a8a9-4960-430c-9a2e-9422d27497fe", false, "user21" },
                    { "user22", 0, "d5181e3b-9c59-4f06-9060-dc64595826a8", "user22@example.com", true, "FirstName22", "LastName22", false, null, "USER22@EXAMPLE.COM", "USER22", "AQAAAAIAAYagAAAAEPIjqJYs9XgEi/b2qsNZdxDPFAZxzfeX2f7+yFCmV5n43rHH8stiTpUTPTIWh00wTA==", null, false, "350a64fe-d56d-4b1d-9253-59a787e5537e", false, "user22" },
                    { "user23", 0, "a586367a-e523-4c2e-8063-bf54eea8813b", "user23@example.com", true, "FirstName23", "LastName23", false, null, "USER23@EXAMPLE.COM", "USER23", "AQAAAAIAAYagAAAAECbOnQF79e5J1v5Oij57dNo11t10mnFqhWs6PMQGlKVAebAMQ9gkLJ1OR8lbEG0SQQ==", null, false, "9d7654ce-1800-4204-8eeb-85f045be2f88", false, "user23" },
                    { "user24", 0, "6ef9fe59-3e56-44e5-8eb2-9be0fad7e1d4", "user24@example.com", true, "FirstName24", "LastName24", false, null, "USER24@EXAMPLE.COM", "USER24", "AQAAAAIAAYagAAAAEKTCinH3ktQuQV1PwlethFe3cZzG9xFAKRq+crOAkzPhD9Elnl3RQaS/MuFwpEnZ2w==", null, false, "f6a82d7a-6210-4072-8cf1-997612a55cac", false, "user24" },
                    { "user25", 0, "04ca9641-347f-4d7b-a300-86f9ca4d054b", "user25@example.com", true, "FirstName25", "LastName25", false, null, "USER25@EXAMPLE.COM", "USER25", "AQAAAAIAAYagAAAAEKQ3Gn0jbBBOjdPNLL5za3w870wFJLfZmRluEFCcZxD9yUrVltgRQSnSKnGqYs8dcQ==", null, false, "eacdc0de-02f1-4562-bf6c-2d306b7cafea", false, "user25" },
                    { "user7", 0, "c3cb9651-0d68-48ab-921c-9f95bedac2fe", "user7@example.com", true, "FirstName7", "LastName7", false, null, "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEC5rsHchDkhIJ8UKgB4ttXf73HSr5XDDPIFrl+J9TURkuNWNb+AhzuSfG22b0LxRkg==", null, false, "248f8d61-dc72-406b-8165-93f25360a878", false, "user7" },
                    { "user8", 0, "ce262081-f6e7-4312-95ed-33a4670e04c5", "user8@example.com", true, "FirstName8", "LastName8", false, null, "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEDdkbzG1sDmT2fspLXWV+Za9qmLNbbJHf67l/HxXt0k5r+KLgdwVbvhV4hQkfdaCbg==", null, false, "77e2cef8-f5be-4bb7-b835-7db20e1e7033", false, "user8" },
                    { "user9", 0, "a314b662-6340-4f18-943a-f4ea9ee42e33", "user9@example.com", true, "FirstName9", "LastName9", false, null, "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEJQp2C2v9iTPRaV6/RuwovT7l6vsE1iGA7efd+swDGxZYZFOQjqX+Veg1l/AaviYwA==", null, false, "a849ef6b-2c06-4f3e-9848-316c77f9725f", false, "user9" }
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Actor1", "Actor2", "Actor3", "AddedAt", "Description", "Genre", "IsSeries", "NumberOfEpisodes", "NumberOfSeasons", "Title" },
                values: new object[] { "Arnold Schwarzenegger", "Linda Hamilton", "Edward Furlong", new DateTime(2025, 1, 7, 10, 28, 17, 628, DateTimeKind.Local).AddTicks(6676), "A gépek és emberek háborújának közepén a jövőbeli vezető, John Connor, visszaküldi a Terminátort, hogy megvédje a fiatalabb önmagát a gépek elől.", "Akció", false, null, null, "Terminátor 2" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Actor1", "Actor2", "Actor3", "AddedAt", "Description", "IsSeries", "NumberOfEpisodes", "NumberOfSeasons", "Title" },
                values: new object[] { "Leonardo DiCaprio", "Joseph Gordon-Levitt", "Ellen Page", new DateTime(2025, 1, 7, 10, 28, 17, 628, DateTimeKind.Local).AddTicks(6889), "Egy tolvaj, aki képes az emberek álmaiba behatolni, egy utolsó küldetést kap, amely megváltoztatja az emberiség jövőjét.", false, null, null, "Eredet" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Actor1", "Actor2", "Actor3", "AddedAt", "Description", "IsSeries", "NumberOfEpisodes", "NumberOfSeasons", "Title" },
                values: new object[] { "Keanu Reeves", "Laurence Fishburne", "Carrie-Anne Moss", new DateTime(2025, 1, 7, 10, 28, 17, 628, DateTimeKind.Local).AddTicks(7038), "A hacker, Neo, felfedezi, hogy a világ, amiben él, valójában egy mesterségesen generált álom, és elindul a harc a valóság megszerzéséért.", false, null, null, "Mátrix" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Actor1", "Actor2", "Actor3", "AddedAt", "Description", "Genre", "IsSeries", "NumberOfEpisodes", "NumberOfSeasons", "Title" },
                values: new object[] { "Marlon Brando", "Al Pacino", "James Caan", new DateTime(2025, 1, 7, 10, 28, 17, 628, DateTimeKind.Local).AddTicks(7177), "A Corleone család, egy olasz-amerikai maffiacsalád, és annak hatalma, politikai befolyása, valamint a családi kapcsolatok története.", "Krimi", false, null, null, "A keresztapa" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Actor1", "Actor2", "Actor3", "AddedAt", "Description", "Director", "Genre", "IsSeries", "Length", "NumberOfEpisodes", "NumberOfSeasons", "Poster", "ReleasedDate", "Title", "WatchlistId" },
                values: new object[,]
                {
                    { 5, "Christian Bale", "Heath Ledger", "Aaron Eckhart", new DateTime(2025, 1, 7, 10, 28, 17, 628, DateTimeKind.Local).AddTicks(7385), "Batman szembesül Jokerrrel, a gonosz nevettetővel, aki a Gotham városában uralkodó káoszt szeretné elérni, miközben saját identitásának és elveinek határait is feszegeti.", "Christopher Nolan", "Akció", false, 152, null, null, null, new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "A sötét lovag", null },
                    { 6, "John Travolta", "Uma Thurman", "Samuel L. Jackson", new DateTime(2025, 1, 7, 10, 28, 17, 628, DateTimeKind.Local).AddTicks(7537), "Két bérgyilkos napi kalandjait követhetjük, miközben véletlenek és szórakoztató párbeszédek révén kibontakozik egy sötét humorral teli történet.", "Quentin Tarantino", "Krimi", false, 154, null, null, null, new DateTime(1994, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ponyvaregény", null },
                    { 7, "Mark Hamill", "Harrison Ford", "Carrie Fisher", new DateTime(2025, 1, 7, 10, 28, 17, 628, DateTimeKind.Local).AddTicks(7819), "Luke Skywalker és barátai a Birodalom elleni harc során igyekeznek megsemmisíteni a Halálcsillagot, miközben felfedezik saját erejüket és küldetésüket.", "George Lucas", "Sci-Fi", false, 121, null, null, null, new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Egy új remény", null },
                    { 8, "Sigourney Weaver", "Tom Skerritt", "John Hurt", new DateTime(2025, 1, 7, 10, 28, 17, 628, DateTimeKind.Local).AddTicks(7959), "A Nostromo űrhajó legénysége egy ismeretlen bolygóról hozott idegen lénytől kezd el rettegni, miközben kétségbeesetten próbálnak életben maradni.", "Ridley Scott", "Sci-Fi", false, 117, null, null, null, new DateTime(1979, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "A nyolcadik utas: a Halál", null },
                    { 9, "Russell Crowe", "Joaquin Phoenix", "Connie Nielsen", new DateTime(2025, 1, 7, 10, 28, 17, 628, DateTimeKind.Local).AddTicks(8103), "Maximus, egy római katona, akit árulás miatt a császári család ellenségei elárulnak, gladiátorként próbál visszavágni a római birodalom hatalmának megdöntéséért.", "Ridley Scott", "Történelmi", false, 155, null, null, null, new DateTime(2000, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gladiátor", null },
                    { 10, "Tom Hanks", "Robin Wright", "Gary Sinise", new DateTime(2025, 1, 7, 10, 28, 17, 628, DateTimeKind.Local).AddTicks(8251), "Forrest Gump története, aki egyszerű elmebeli képességekkel rendelkezik, de életét olyan fontos történelmi események formálják, amelyekkel sokak számára inspirációt ad.", "Robert Zemeckis", "Dráma", false, 142, null, null, null, new DateTime(1994, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Forrest Gump", null },
                    { 11, "Tim Robbins", "Morgan Freeman", "Bob Gunton", new DateTime(2025, 1, 7, 10, 28, 17, 628, DateTimeKind.Local).AddTicks(8426), "Andy Dufresne, egy bankár ártatlanul letartóztatva, élete végéig a Shawshank börtönben próbál meg túlélni, miközben megőrzi reményét és titkos tervét.", "Frank Darabont", "Dráma", false, 142, null, null, null, new DateTime(1994, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "A remény rabjai", null },
                    { 12, "Liam Neeson", "Ben Kingsley", "Ralph Fiennes", new DateTime(2025, 1, 7, 10, 28, 17, 628, DateTimeKind.Local).AddTicks(8606), "A film Schindler történetét követi, aki a második világháború alatt több mint ezer zsidó életét mentette meg, miközben sikeresen elkerülte a náci hatóságok figyelmét.", "Steven Spielberg", "Történelmi", false, 195, null, null, null, new DateTime(1993, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Schindler listája", null },
                    { 13, "Leonardo DiCaprio", "Matt Damon", "Jack Nicholson", new DateTime(2025, 1, 7, 10, 28, 17, 628, DateTimeKind.Local).AddTicks(8785), "Billy Costigan, egy fiatal rendőr, beépül a bostoni maffiába, miközben a maffia ügyeiért dolgozó Colin Sullivan titkosszolgálati informátorként segíti a bűnözőket.", "Martin Scorsese", "Krimi", false, 151, null, null, null, new DateTime(2006, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "A tégla", null },
                    { 14, "Jamie Foxx", "Christoph Waltz", "Leonardo DiCaprio", new DateTime(2025, 1, 7, 10, 28, 17, 628, DateTimeKind.Local).AddTicks(8951), "Django, egy felszabadított rabszolga, szövetséget köt egy német fejvadásszal, hogy megmentsen feleségét, és igazságot szolgáltasson egy brutális rabszolga-kereskedőnek.", "Quentin Tarantino", "Western", false, 165, null, null, null, new DateTime(2012, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Django elszabadul", null },
                    { 15, "Clint Eastwood", "Lee Van Cleef", "Eli Wallach", new DateTime(2025, 1, 7, 10, 28, 17, 628, DateTimeKind.Local).AddTicks(9123), "A film három különböző férfi keresztutjait követi, akik a vadnyugat törvényei szerint küzdenek a túlélésért, miközben egy hatalmas bűnügyi összeesküvésben vesznek részt.", "Sergio Leone", "Western", false, 165, null, null, null, new DateTime(1968, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "A vadnyugat hőskora", null },
                    { 16, "Leonardo DiCaprio", "Kate Winslet", "Billy Zane", new DateTime(2025, 1, 7, 10, 28, 17, 628, DateTimeKind.Local).AddTicks(9293), "Jack és Rose szerelmének története, akik egy tragikus sorsú hajón, a Titanic fedélzetén találkoznak és élnek át mindent, ami a sors által nekik kijut.", "James Cameron", "Romantikus", false, 195, null, null, null, new DateTime(1997, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Titanic", null },
                    { 17, "Ryan Gosling", "Rachel McAdams", "James Garner", new DateTime(2025, 1, 7, 10, 28, 17, 628, DateTimeKind.Local).AddTicks(9430), "Noah és Allie szerelme, mely hosszú évek után sem halványul el, miközben két különböző világ találkozik és a szeretet mindent legyőz.", "Nick Cassavetes", "Romantikus", false, 123, null, null, null, new DateTime(2004, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Szerelmünk lapjai", null },
                    { 18, "Bill Murray", "Dan Aykroyd", "Sigourney Weaver", new DateTime(2025, 1, 7, 10, 28, 17, 628, DateTimeKind.Local).AddTicks(9566), "Három tudós és egy szellemirtó csoport létrehozása, akik New York városában az emelkedő szellemeket és paranormális jelenségeket kezdik el üldözni.", "Ivan Reitman", "Vígjáték", false, 105, null, null, null, new DateTime(1984, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Szellemirtók", null },
                    { 19, "John Candy", "Joe Flaherty", "Harold Ramis", new DateTime(2025, 1, 7, 10, 28, 17, 628, DateTimeKind.Local).AddTicks(9699), "Két bűnöző, akik nemcsak az igazságszolgáltatás elől menekülnek, hanem saját szörnyű döntéseik következményeivel is küzdenek egy hatalmas vígjátékban.", "Jim Abrahams", "Vígjáték", false, 84, null, null, null, new DateTime(1991, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nagy durranás", null },
                    { 20, "Jim Carrey", "Courtney Cox", "Sean Young", new DateTime(2025, 1, 7, 10, 28, 17, 628, DateTimeKind.Local).AddTicks(9838), "Ace Ventura, egy szórakoztató és zűrös állati nyomozó, aki segít visszaszerezni egy eltűnt delfint, miközben elképesztő kalandokon megy keresztül.", "Tom Shadyac", "Vígjáték", false, 86, null, null, null, new DateTime(1994, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ace Ventura: Állati nyomozó", null },
                    { 21, "Heather Langenkamp", "Johnny Depp", "Robert Englund", new DateTime(2025, 1, 7, 10, 28, 17, 628, DateTimeKind.Local).AddTicks(9981), "Freddy Krueger, a szörnyű álmok gyilkosa visszatér, hogy a fiatalokat egy rémálomban elpusztítsa, miközben ők próbálják kideríteni, hogyan állíthatják meg őt.", "Wes Craven", "Horror", false, 91, null, null, null, new DateTime(1984, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rémálom az Elm utcában", null },
                    { 22, "Ellen Burstyn", "Max von Sydow", "Linda Blair", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(121), "A fiatal Regan MacNeil-t egy gonosz démon szállja meg, és egy pap segítségét kérik, hogy kiűzzék a démoni jelenlétet, miközben a szülők kétségbeesetten küzdenek.", "William Friedkin", "Horror", false, 122, null, null, null, new DateTime(1973, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Az ördögűző", null },
                    { 23, "Jamie Lee Curtis", "Donald Pleasence", "Tony Moran", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(267), "Michael Myers, a gyilkos, aki elmenekült egy pszichiátriai intézetből, hogy folytassa az áldozatok sorozatát Halloween éjszakáján, miközben Laurie Strode próbál túlélni.", "John Carpenter", "Horror", false, 91, null, null, null, new DateTime(1978, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Halloween", null },
                    { 24, "Betsy Palmer", "Adrienne King", "Harry Manfredini", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(428), "A Crystal Lake kempingezői sorozatos gyilkosságokat tapasztalnak, miközben egy rejtélyes gyilkos, Jason Voorhees újra és újra támadja őket.", "Sean S. Cunningham", "Horror", false, 95, null, null, null, new DateTime(1980, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Péntek 13.", null },
                    { 25, "Matthew McConaughey", "Anne Hathaway", "Jessica Chastain", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(562), "A Föld elpusztulása előtt egy csapat űrhajós a galaxisba indul, hogy egy új otthont találjon az emberiség számára, miközben mélyen elgondolkodtató kérdéseket vetnek fel az időről és a szeretetről.", "Christopher Nolan", "Sci-Fi", false, 169, null, null, null, new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interstellar", null },
                    { 26, "Leonardo DiCaprio", "Tom Hardy", "Domhnall Gleeson", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(781), "Hugh Glass, egy vadász, akit egy medve súlyosan megsebesít, és úgy hagynak, hogy meghaljon, visszavág és igyekszik túlélni a vadonban, miközben bosszút esküszik az őt cserbenhagyó társai ellen.", "Alejandro G. Iñárritu", "Kaland", false, 156, null, null, null, new DateTime(2015, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "A visszatérő", null },
                    { 27, "Elijah Wood", "Ian McKellen", "Viggo Mortensen", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(930), "A háború végső csatája kezdődik, miközben Frodo és Sam közel járnak a Sötét Úr, Sauron megsemmisítéséhez, miközben Aragorn és a Szövetség a háborúban harcol.", "Peter Jackson", "Kaland", false, 201, null, null, null, new DateTime(2003, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "A gyűrűk ura: A király visszatér", null },
                    { 28, "Daniel Radcliffe", "Rupert Grint", "Emma Watson", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(1062), "Harry Potter felfedezi, hogy ő egy varázsló, és elindul a mágikus világban, miközben barátaival egy misztikus kő nyomában járnak, hogy megakadályozzák a sötét varázsló visszatérését.", "Chris Columbus", "Kaland", false, 152, null, null, null, new DateTime(2001, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harry Potter és a bölcsek köve", null },
                    { 29, "Harrison Ford", "Karen Allen", "Paul Freeman", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(1204), "Indiana Jones, a kalandor régész, megpróbálja megelőzni a nácikat, akik az elveszett frigyládát keresik, egy titkos ereklyét, amely hatalmas hatalommal bír.", "Steven Spielberg", "Kaland", false, 115, null, null, null, new DateTime(1981, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indiana Jones és az elveszett frigyláda fosztogatói", null },
                    { 30, "Russell Crowe", "Jennifer Connelly", "Ed Harris", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(1346), "John Nash, a zseniális matematikus, a skizofréniával küzd, miközben próbálja megérteni a saját elméjét, és harcol a belső démonokkal, hogy megtartsa a karrierjét és a szerelmét.", "Ron Howard", "Dráma", false, 135, null, null, null, new DateTime(2001, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Egy csodálatos elme", null },
                    { 31, "Miles Teller", "J.K. Simmons", "Melissa Benoist", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(1515), "Andrew, egy fiatal dobos, mindent feláldoz, hogy elérje álmait, miközben egy szigorú és manipulatív tanár, Fletcher próbálja elérni, hogy a legjobbat hozza ki belőle.", "Damien Chazelle", "Dráma", false, 106, null, null, null, new DateTime(2014, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Whiplash", null },
                    { 32, "Harrison Ford", "Rutger Hauer", "Sean Young", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(1650), "Rick Deckard, egy szárnyas fejvadász, aki egy újabb gyilkos androidot kell, hogy levadásszon, kétségbeesetten keres egy igazságot egy világban, amelyben a gépek és az emberek közötti határok elmosódnak.", "Ridley Scott", "Sci-Fi", false, 117, null, null, null, new DateTime(1982, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Szárnyas fejvadász", null },
                    { 33, "Edward Norton", "Liv Tyler", "Tim Roth", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(1781), "Bruce Banner, aki tudatosan próbálja megállítani a szörnyű szörnyeteg Hulkot, miután egy kísérlet következtében folyamatosan mutálódik, miközben el akarja kerülni, hogy a katonai hatalom elfogja őt.", "Louis Leterrier", "Akció", false, 112, null, null, null, new DateTime(2008, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "A hihetetlen Hulk", null },
                    { 34, "Mike Myers", "Beyoncé Knowles", "Vernon Troyer", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(1911), "Austin Powers, a híres brit titkos ügynök, visszatér, hogy megakadályozza a gonosz Dr. Evil tervét, miközben a nevetés határain túl is szórakoztatja a közönséget.", "Jay Roach", "Vígjáték", false, 95, null, null, null, new DateTime(1999, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "KicsiKÉM – Austin Powers 2.", null },
                    { 35, "Johnny Depp", "Armie Hammer", "Tom Wilkinson", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(2052), "A vadnyugat határain túl egy különös kettős kapcsolat alakul ki: a titokzatos Lone Ranger és Tonto, az indián kísérője, hogy felvegyék a harcot a korrupt erőkkel.", "Gore Verbinski", "Western", false, 149, null, null, null, new DateTime(2013, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "A magányos lovas", null },
                    { 36, "Chadwick Boseman", "Michael B. Jordan", "Lupita Nyong'o", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(2186), "T'Challa, Wakanda királya és új Fekete Párduc, szembesül egy nagy hatalmú ellenséggel, aki megpróbálja felfedni országát és kihasználni annak gazdagságát.", "Ryan Coogler", "Akció", false, 134, null, null, null, new DateTime(2018, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fekete Párduc", null },
                    { 37, "Ryan Reynolds", "Morena Baccarin", "T.J. Miller", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(2324), "Wade Wilson, egy egykori különleges erőket végző katona, akit kísérletezéssel alakítanak át, hogy megszerezze gyógyító képességét, és harcba száll a bűnözőkkel.", "Tim Miller", "Akció", false, 108, null, null, null, new DateTime(2016, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deadpool", null },
                    { 38, "Hugh Jackman", "Patrick Stewart", "Dafne Keen", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(2463), "Logan, az öreg és beteg X-Men tag, segít egy fiatal mutantot elmenekülni, miközben harcol saját szellemi és fizikai határain túl.", "James Mangold", "Akció", false, 137, null, null, null, new DateTime(2017, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Logan", null },
                    { 39, "Ben Affleck", "Henry Cavill", "Gal Gadot", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(2602), "Batman és Superman összecsapása, miközben mindketten próbálják megérteni, miért kell harcolniuk, miközben a világot egy új fenyegetés is veszélyezteti.", "Zack Snyder", "Akció", false, 151, null, null, null, new DateTime(2016, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman v Superman: Az igazság hajnal", null },
                    { 40, "Ryan Reynolds", "Josh Brolin", "Zazie Beetz", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(2740), "Deadpool visszatér, hogy egy új csapatot toborozzon, miközben harcol a világot fenyegető gonosz erőkkel, és megpróbálja felfedezni saját személyiségét.", "David Leitch", "Akció", false, 119, null, null, null, new DateTime(2018, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deadpool 2", null },
                    { 41, "Winona Ryder", "David Harbour", "Millie Bobby Brown", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(2870), "Egy kisvárosban, Hawkinsban, különös események kezdődnek el, miután egy fiú eltűnik, és egy titokzatos lány jelenik meg, aki különleges képességekkel rendelkezik.", "The Duffer Brothers", "Horror, Sci-Fi", true, 50, 40, 5, null, new DateTime(2016, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stranger Things", null },
                    { 42, "Emilia Clarke", "Kit Harington", "Peter Dinklage", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(3012), "A különböző házak harcolnak a Trónok harca során, miközben a világot fenyegető titokzatos erő egyre közelebb kerül.", "David Benioff, D.B. Weiss", "Fantasy, Drama", true, 60, 73, 8, null, new DateTime(2011, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Game of Thrones", null },
                    { 43, "Bryan Cranston", "Aaron Paul", "Anna Gunn", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(3148), "Egy középiskolai kémiatanár rákos betegségből kifolyólag egy bűnözői világba lép, hogy biztosítja családja jövőjét.", "Vince Gilligan", "Crime, Drama, Thriller", true, 47, 62, 5, null, new DateTime(2008, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breaking Bad", null },
                    { 44, "Henry Cavill", "Anya Chalotra", "Freya Allan", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(3281), "Geralt of Rivia, a szörnyvadász egy elragadó világban navigál, miközben titokzatos erők és politikai játszmák sodorják a történet fonalát.", "Lauren Schmidt Hissrich", "Action, Adventure, Drama", true, 60, 16, 2, null, new DateTime(2019, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Witcher", null },
                    { 45, "Pedro Pascal", "Gina Carano", "Carl Weathers", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(3413), "A történet egy mandalóri harcos körül forog, aki galaxisok között vándorol, miközben megpróbálja megvédeni egy rejtélyes, erővel rendelkező gyermeket.", "Jon Favreau", "Action, Adventure, Fantasy", true, 40, 24, 3, null, new DateTime(2019, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Mandalorian", null },
                    { 46, "Úrsula Corberó", "Álvaro Morte", "Itziar Ituño", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(3553), "Egy titokzatos férfi és csapata különböző bankokat rabol ki, miközben az egész világ szeme rajtuk van.", "Álex Pina", "Action, Crime, Drama", true, 50, 48, 5, null, new DateTime(2017, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Money Heist", null },
                    { 47, "Claire Foy", "Matt Smith", "Vanessa Kirby", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(3712), "A brit királyi család életét követi nyomon, különös figyelmet fordítva II. Erzsébet uralkodására és a hozzá kapcsolódó politikai eseményekre.", "Peter Morgan", "Biography, Drama, History", true, 60, 60, 6, null, new DateTime(2016, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Crown", null },
                    { 48, "Karl Urban", "Jack Quaid", "Antony Starr", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(3843), "A szuperhősök világát követi, de ezek nem azok a hősök, akikről álmodtunk. A ‘Boys’ egy csapat, amely felkészül arra, hogy megállítsa a veszélyes szuperhősöket.", "Eric Kripke", "Action, Comedy, Crime", true, 60, 24, 3, null, new DateTime(2019, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Boys", null },
                    { 49, "Louis Hofmann", "Oliver Masucci", "Maja Schöne", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(4019), "A történet egy kis német városban játszódik, ahol eltűnések és időutazás kezd el felfedni titkokat a múltból és a jövőből.", "Baran bo Odar", "Drama, Mystery, Sci-Fi", true, 60, 26, 3, null, new DateTime(2017, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dark", null },
                    { 50, "Wagner Moura", "Pedro Pascal", "Boyd Holbrook", new DateTime(2025, 1, 7, 10, 28, 17, 629, DateTimeKind.Local).AddTicks(4216), "A kolumbiai drogkartell és a rendőrség harcát követi nyomon, miközben a bűnözői világ titkai és hatalmi játszmái is kibontakoznak.", "Chris Brancato, Carlo Bernard, Doug Miro", "Biography, Crime, Drama", true, 60, 30, 3, null, new DateTime(2015, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Narcos", null }
                });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comment", "RatingNumber", "UserId" },
                values: new object[] { "Egyszerűen fantasztikus, nem tudom eléggé dicsérni!", 5, "user13" });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Comment", "RatingNumber", "UserId" },
                values: new object[] { "Kicsit lassú volt a tempó, de összességében jó.", 2, "user25" });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Comment", "MovieId", "RatingNumber", "UserId" },
                values: new object[] { "Hihetetlen történet, teljesen magával ragadott!", 1, 3, "user15" });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Comment", "MovieId", "RatingNumber", "UserId" },
                values: new object[] { "Valóban mestermű, mindenkinek ajánlom!", 1, 2, "user3" });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Comment", "MovieId", "RatingNumber", "UserId" },
                values: new object[] { "Egyszerűen fantasztikus, nem tudom eléggé dicsérni!", 2, 3, "user16" });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Comment", "MovieId", "RatingNumber", "UserId" },
                values: new object[] { "A karakterek nagyon jól kidolgozottak.", 2, 3, "user1" });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Comment", "MovieId", "RatingNumber", "UserId" },
                values: new object[] { "Nagyszerű film, nagyon élveztem!", 2, 4, "user20" });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Comment", "MovieId", "RatingNumber", "UserId" },
                values: new object[] { "Valóban mestermű, mindenkinek ajánlom!", 2, 5, "user17" });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Comment", "MovieId", "RatingNumber", "UserId" },
                values: new object[,]
                {
                    { 15, "A karakterek nagyon jól kidolgozottak.", 4, 1, "user5" },
                    { 16, "Valóban mestermű, mindenkinek ajánlom!", 4, 4, "user4" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "user-role-id", "user10" },
                    { "user-role-id", "user11" },
                    { "user-role-id", "user12" },
                    { "user-role-id", "user13" },
                    { "user-role-id", "user14" },
                    { "user-role-id", "user15" },
                    { "user-role-id", "user16" },
                    { "user-role-id", "user17" },
                    { "user-role-id", "user18" },
                    { "user-role-id", "user19" },
                    { "user-role-id", "user20" },
                    { "user-role-id", "user21" },
                    { "user-role-id", "user22" },
                    { "user-role-id", "user23" },
                    { "user-role-id", "user24" },
                    { "user-role-id", "user25" },
                    { "user-role-id", "user7" },
                    { "user-role-id", "user8" },
                    { "user-role-id", "user9" }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Comment", "MovieId", "RatingNumber", "UserId" },
                values: new object[,]
                {
                    { 9, "Sokkal jobb, mint amire számítottam.", 3, 5, "user8" },
                    { 10, "Lenyűgöző látványvilág és remek színészi játék!", 3, 2, "user25" },
                    { 11, "Nagyszerű film, nagyon élveztem!", 3, 2, "user15" },
                    { 12, "Nagyszerű film, nagyon élveztem!", 3, 2, "user13" },
                    { 13, "Lenyűgöző látványvilág és remek színészi játék!", 4, 2, "user19" },
                    { 14, "Valóban mestermű, mindenkinek ajánlom!", 4, 5, "user16" },
                    { 17, "Kicsit lassú volt a tempó, de összességében jó.", 5, 3, "user23" },
                    { 18, "A karakterek nagyon jól kidolgozottak.", 5, 5, "user21" },
                    { 19, "Sokkal jobb, mint amire számítottam.", 5, 3, "user5" },
                    { 20, "Valóban mestermű, mindenkinek ajánlom!", 5, 4, "user22" },
                    { 21, "Lenyűgöző látványvilág és remek színészi játék!", 6, 5, "user6" },
                    { 22, "Nem igazán az én ízlésem, de értem miért szeretik.", 6, 3, "user2" },
                    { 23, "A karakterek nagyon jól kidolgozottak.", 6, 2, "user22" },
                    { 24, "Sokkal jobb, mint amire számítottam.", 6, 1, "user3" },
                    { 25, "Valóban mestermű, mindenkinek ajánlom!", 7, 2, "user24" },
                    { 26, "Kicsit lassú volt a tempó, de összességében jó.", 7, 5, "user6" },
                    { 27, "Sokkal jobb, mint amire számítottam.", 7, 5, "user21" },
                    { 28, "Kicsit lassú volt a tempó, de összességében jó.", 7, 3, "user3" },
                    { 29, "Lenyűgöző látványvilág és remek színészi játék!", 8, 1, "user20" },
                    { 30, "Nagyszerű film, nagyon élveztem!", 8, 3, "user24" },
                    { 31, "Egyszerűen fantasztikus, nem tudom eléggé dicsérni!", 8, 2, "user10" },
                    { 32, "Kissé kiszámítható, de azért szórakoztató.", 8, 3, "user11" },
                    { 33, "Sokkal jobb, mint amire számítottam.", 9, 2, "user16" },
                    { 34, "Egyszerűen fantasztikus, nem tudom eléggé dicsérni!", 9, 1, "user17" },
                    { 35, "Hihetetlen történet, teljesen magával ragadott!", 9, 1, "user23" },
                    { 36, "Hihetetlen történet, teljesen magával ragadott!", 9, 5, "user9" },
                    { 37, "Kicsit lassú volt a tempó, de összességében jó.", 10, 1, "user3" },
                    { 38, "Nem igazán az én ízlésem, de értem miért szeretik.", 10, 5, "user15" },
                    { 39, "Lenyűgöző látványvilág és remek színészi játék!", 10, 5, "user8" },
                    { 40, "A karakterek nagyon jól kidolgozottak.", 10, 2, "user1" },
                    { 41, "Egyszerűen fantasztikus, nem tudom eléggé dicsérni!", 11, 1, "user21" },
                    { 42, "Hihetetlen történet, teljesen magával ragadott!", 11, 2, "user12" },
                    { 43, "Nem igazán az én ízlésem, de értem miért szeretik.", 11, 5, "user17" },
                    { 44, "Kicsit lassú volt a tempó, de összességében jó.", 11, 3, "user11" },
                    { 45, "Lenyűgöző látványvilág és remek színészi játék!", 12, 3, "user25" },
                    { 46, "A karakterek nagyon jól kidolgozottak.", 12, 3, "user20" },
                    { 47, "Nem igazán az én ízlésem, de értem miért szeretik.", 12, 4, "user23" },
                    { 48, "Nem igazán az én ízlésem, de értem miért szeretik.", 12, 3, "user10" },
                    { 49, "Hihetetlen történet, teljesen magával ragadott!", 13, 2, "user3" },
                    { 50, "Kicsit lassú volt a tempó, de összességében jó.", 13, 1, "user2" },
                    { 51, "Sokkal jobb, mint amire számítottam.", 13, 4, "user15" },
                    { 52, "Nem igazán az én ízlésem, de értem miért szeretik.", 13, 4, "user23" },
                    { 53, "A karakterek nagyon jól kidolgozottak.", 14, 1, "user4" },
                    { 54, "Nagyszerű film, nagyon élveztem!", 14, 4, "user16" },
                    { 55, "Hihetetlen történet, teljesen magával ragadott!", 14, 2, "user5" },
                    { 56, "Sokkal jobb, mint amire számítottam.", 14, 4, "user6" },
                    { 57, "Valóban mestermű, mindenkinek ajánlom!", 15, 3, "user1" },
                    { 58, "Kicsit lassú volt a tempó, de összességében jó.", 15, 3, "user8" },
                    { 59, "Kissé kiszámítható, de azért szórakoztató.", 15, 1, "user23" },
                    { 60, "Sokkal jobb, mint amire számítottam.", 15, 2, "user18" },
                    { 61, "Nem igazán az én ízlésem, de értem miért szeretik.", 16, 3, "user18" },
                    { 62, "Kicsit lassú volt a tempó, de összességében jó.", 16, 1, "user5" },
                    { 63, "Egyszerűen fantasztikus, nem tudom eléggé dicsérni!", 16, 1, "user12" },
                    { 64, "Egyszerűen fantasztikus, nem tudom eléggé dicsérni!", 16, 4, "user8" },
                    { 65, "Kicsit lassú volt a tempó, de összességében jó.", 17, 5, "user11" },
                    { 66, "Nagyszerű film, nagyon élveztem!", 17, 5, "user21" },
                    { 67, "A karakterek nagyon jól kidolgozottak.", 17, 3, "user13" },
                    { 68, "Hihetetlen történet, teljesen magával ragadott!", 17, 5, "user2" },
                    { 69, "Lenyűgöző látványvilág és remek színészi játék!", 18, 5, "user16" },
                    { 70, "Nem igazán az én ízlésem, de értem miért szeretik.", 18, 3, "user4" },
                    { 71, "Nem igazán az én ízlésem, de értem miért szeretik.", 18, 5, "user3" },
                    { 72, "Valóban mestermű, mindenkinek ajánlom!", 18, 5, "user25" },
                    { 73, "Valóban mestermű, mindenkinek ajánlom!", 19, 5, "user5" },
                    { 74, "Lenyűgöző látványvilág és remek színészi játék!", 19, 5, "user9" },
                    { 75, "A karakterek nagyon jól kidolgozottak.", 19, 2, "user11" },
                    { 76, "Egyszerűen fantasztikus, nem tudom eléggé dicsérni!", 19, 2, "user18" },
                    { 77, "Lenyűgöző látványvilág és remek színészi játék!", 20, 5, "user19" },
                    { 78, "Hihetetlen történet, teljesen magával ragadott!", 20, 1, "user15" },
                    { 79, "Hihetetlen történet, teljesen magával ragadott!", 20, 3, "user24" },
                    { 80, "Sokkal jobb, mint amire számítottam.", 20, 2, "user2" },
                    { 81, "Valóban mestermű, mindenkinek ajánlom!", 21, 1, "user7" },
                    { 82, "Kissé kiszámítható, de azért szórakoztató.", 21, 5, "user14" },
                    { 83, "Nagyszerű film, nagyon élveztem!", 21, 1, "user6" },
                    { 84, "Lenyűgöző látványvilág és remek színészi játék!", 21, 3, "user22" },
                    { 85, "A karakterek nagyon jól kidolgozottak.", 22, 1, "user5" },
                    { 86, "Nem igazán az én ízlésem, de értem miért szeretik.", 22, 1, "user10" },
                    { 87, "Kissé kiszámítható, de azért szórakoztató.", 22, 1, "user7" },
                    { 88, "Egyszerűen fantasztikus, nem tudom eléggé dicsérni!", 22, 1, "user2" },
                    { 89, "Kissé kiszámítható, de azért szórakoztató.", 23, 4, "user14" },
                    { 90, "Lenyűgöző látványvilág és remek színészi játék!", 23, 3, "user10" },
                    { 91, "Egyszerűen fantasztikus, nem tudom eléggé dicsérni!", 23, 5, "user7" },
                    { 92, "Sokkal jobb, mint amire számítottam.", 23, 5, "user23" },
                    { 93, "Egyszerűen fantasztikus, nem tudom eléggé dicsérni!", 24, 3, "user21" },
                    { 94, "Nagyszerű film, nagyon élveztem!", 24, 5, "user25" },
                    { 95, "A karakterek nagyon jól kidolgozottak.", 24, 1, "user17" },
                    { 96, "Lenyűgöző látványvilág és remek színészi játék!", 24, 5, "user18" },
                    { 97, "Egyszerűen fantasztikus, nem tudom eléggé dicsérni!", 25, 4, "user4" },
                    { 98, "Nagyszerű film, nagyon élveztem!", 25, 5, "user15" },
                    { 99, "Hihetetlen történet, teljesen magával ragadott!", 25, 3, "user6" },
                    { 100, "A karakterek nagyon jól kidolgozottak.", 25, 2, "user10" },
                    { 101, "Kicsit lassú volt a tempó, de összességében jó.", 26, 2, "user5" },
                    { 102, "Egyszerűen fantasztikus, nem tudom eléggé dicsérni!", 26, 4, "user10" },
                    { 103, "Valóban mestermű, mindenkinek ajánlom!", 26, 1, "user16" },
                    { 104, "Hihetetlen történet, teljesen magával ragadott!", 26, 2, "user7" },
                    { 105, "Lenyűgöző látványvilág és remek színészi játék!", 27, 5, "user22" },
                    { 106, "Egyszerűen fantasztikus, nem tudom eléggé dicsérni!", 27, 5, "user21" },
                    { 107, "Kicsit lassú volt a tempó, de összességében jó.", 27, 3, "user10" },
                    { 108, "Kicsit lassú volt a tempó, de összességében jó.", 27, 4, "user3" },
                    { 109, "Sokkal jobb, mint amire számítottam.", 28, 5, "user14" },
                    { 110, "Nagyszerű film, nagyon élveztem!", 28, 1, "user9" },
                    { 111, "Kicsit lassú volt a tempó, de összességében jó.", 28, 3, "user7" },
                    { 112, "Lenyűgöző látványvilág és remek színészi játék!", 28, 2, "user12" },
                    { 113, "Kissé kiszámítható, de azért szórakoztató.", 29, 5, "user15" },
                    { 114, "Egyszerűen fantasztikus, nem tudom eléggé dicsérni!", 29, 3, "user8" },
                    { 115, "Nagyszerű film, nagyon élveztem!", 29, 5, "user11" },
                    { 116, "Kissé kiszámítható, de azért szórakoztató.", 29, 3, "user19" },
                    { 117, "Valóban mestermű, mindenkinek ajánlom!", 30, 1, "user8" },
                    { 118, "Hihetetlen történet, teljesen magával ragadott!", 30, 3, "user19" },
                    { 119, "Valóban mestermű, mindenkinek ajánlom!", 30, 1, "user5" },
                    { 120, "Nem igazán az én ízlésem, de értem miért szeretik.", 30, 2, "user7" },
                    { 121, "Nagyszerű film, nagyon élveztem!", 31, 1, "user18" },
                    { 122, "A karakterek nagyon jól kidolgozottak.", 31, 3, "user8" },
                    { 123, "Lenyűgöző látványvilág és remek színészi játék!", 31, 1, "user4" },
                    { 124, "Lenyűgöző látványvilág és remek színészi játék!", 31, 3, "user16" },
                    { 125, "Valóban mestermű, mindenkinek ajánlom!", 32, 1, "user1" },
                    { 126, "A karakterek nagyon jól kidolgozottak.", 32, 5, "user19" },
                    { 127, "Lenyűgöző látványvilág és remek színészi játék!", 32, 2, "user13" },
                    { 128, "Sokkal jobb, mint amire számítottam.", 32, 4, "user14" },
                    { 129, "A karakterek nagyon jól kidolgozottak.", 33, 2, "user16" },
                    { 130, "Lenyűgöző látványvilág és remek színészi játék!", 33, 4, "user25" },
                    { 131, "Sokkal jobb, mint amire számítottam.", 33, 1, "user23" },
                    { 132, "Kicsit lassú volt a tempó, de összességében jó.", 33, 2, "user15" },
                    { 133, "Lenyűgöző látványvilág és remek színészi játék!", 34, 3, "user22" },
                    { 134, "Kicsit lassú volt a tempó, de összességében jó.", 34, 4, "user20" },
                    { 135, "Hihetetlen történet, teljesen magával ragadott!", 34, 4, "user1" },
                    { 136, "Hihetetlen történet, teljesen magával ragadott!", 34, 4, "user13" },
                    { 137, "Lenyűgöző látványvilág és remek színészi játék!", 35, 2, "user3" },
                    { 138, "Hihetetlen történet, teljesen magával ragadott!", 35, 2, "user6" },
                    { 139, "Kissé kiszámítható, de azért szórakoztató.", 35, 2, "user11" },
                    { 140, "Valóban mestermű, mindenkinek ajánlom!", 35, 4, "user1" },
                    { 141, "Lenyűgöző látványvilág és remek színészi játék!", 36, 3, "user20" },
                    { 142, "Nagyszerű film, nagyon élveztem!", 36, 3, "user7" },
                    { 143, "Nem igazán az én ízlésem, de értem miért szeretik.", 36, 5, "user14" },
                    { 144, "Egyszerűen fantasztikus, nem tudom eléggé dicsérni!", 36, 3, "user19" },
                    { 145, "Kissé kiszámítható, de azért szórakoztató.", 37, 4, "user5" },
                    { 146, "Sokkal jobb, mint amire számítottam.", 37, 4, "user20" },
                    { 147, "Valóban mestermű, mindenkinek ajánlom!", 37, 3, "user12" },
                    { 148, "Nem igazán az én ízlésem, de értem miért szeretik.", 37, 1, "user6" },
                    { 149, "Nem igazán az én ízlésem, de értem miért szeretik.", 38, 1, "user17" },
                    { 150, "Nagyszerű film, nagyon élveztem!", 38, 3, "user5" },
                    { 151, "Egyszerűen fantasztikus, nem tudom eléggé dicsérni!", 38, 4, "user7" },
                    { 152, "Sokkal jobb, mint amire számítottam.", 38, 3, "user24" },
                    { 153, "Kissé kiszámítható, de azért szórakoztató.", 39, 1, "user1" },
                    { 154, "Kissé kiszámítható, de azért szórakoztató.", 39, 3, "user13" },
                    { 155, "Nagyszerű film, nagyon élveztem!", 39, 3, "user14" },
                    { 156, "A karakterek nagyon jól kidolgozottak.", 39, 5, "user2" },
                    { 157, "Nem igazán az én ízlésem, de értem miért szeretik.", 40, 2, "user1" },
                    { 158, "Hihetetlen történet, teljesen magával ragadott!", 40, 5, "user2" },
                    { 159, "Nem igazán az én ízlésem, de értem miért szeretik.", 40, 2, "user13" },
                    { 160, "Nagyszerű film, nagyon élveztem!", 40, 5, "user23" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Watchlists_MovieId",
                table: "Watchlists",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Watchlists_WatchlistId",
                table: "Movies",
                column: "WatchlistId",
                principalTable: "Watchlists",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Watchlists_Movies_MovieId",
                table: "Watchlists",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Watchlists_WatchlistId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Watchlists_Movies_MovieId",
                table: "Watchlists");

            migrationBuilder.DropTable(
                name: "List<string>");

            migrationBuilder.DropIndex(
                name: "IX_Watchlists_MovieId",
                table: "Watchlists");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "user-role-id", "user10" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "user-role-id", "user11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "user-role-id", "user12" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "user-role-id", "user13" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "user-role-id", "user14" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "user-role-id", "user15" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "user-role-id", "user16" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "user-role-id", "user17" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "user-role-id", "user18" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "user-role-id", "user19" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "user-role-id", "user20" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "user-role-id", "user21" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "user-role-id", "user22" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "user-role-id", "user23" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "user-role-id", "user24" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "user-role-id", "user25" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "user-role-id", "user7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "user-role-id", "user8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "user-role-id", "user9" });

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user15");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user16");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user18");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user20");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user21");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user22");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user23");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user25");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user9");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DropColumn(
                name: "Actor1",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Actor2",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Actor3",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "AddedAt",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "IsSeries",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "NumberOfEpisodes",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "NumberOfSeasons",
                table: "Movies");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9231784-b160-423d-af93-b9a289899a64", "John", "Doe", "AQAAAAIAAYagAAAAEOcaXVq5ztAgD4WBFRhB75BJK/NEifSIWTes6WnHnpePv0WQ0VdfycNtc20L+2HwJg==", "647a2584-6da4-42c3-81b4-362c941ae726" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "654845df-fcf4-4839-b163-1cfc1c400df9", "Jane", "Smith", "AQAAAAIAAYagAAAAEFqj4fgWZERFGteUwoJKnahhdjuCYOoovCVxKF7BE9B5VNaSM20CaMIMELfjUMHtiQ==", "6e087875-eeeb-4f84-b869-6c9999baf85d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user3",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "540128b6-ee7a-4846-a8fa-19a4c5e23157", "Alice", "Johnson", "AQAAAAIAAYagAAAAEOsSwT4nmpRcrvNYukwR7Ad1g32RW2EERNnqFoRtURyD+BnR4BWY9nUpuxtHap4P6A==", "a9902876-859e-41b3-9303-b30da760e1df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user4",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45ab2ecb-ac8e-46cd-a0d0-df610fbaed46", "Bob", "Brown", "AQAAAAIAAYagAAAAEHGIPWOxwQJKhRycxd+9o01BsZPqth9xwgJ7fMndNTMBiIVXPktuToGXD2XLM8lTjQ==", "21973137-0204-4fae-94c7-0ba1286c468b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user5",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "706d1640-8d1d-4ccb-8928-93ffa8a7985e", "Charlie", "Davis", "AQAAAAIAAYagAAAAEEqCQZKnB+UpVlSkXsEAW8c1zEM05YKNDi7qZsGRWrS44dlZFrPO+rPCiQ1pxtYRmQ==", "d3801f3e-dfab-44d9-93e2-850763ac56dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user6",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57d73ea3-c294-4d6b-9e1d-f310b7cd2058", "Emily", "Wilson", "AQAAAAIAAYagAAAAEC7kRdOXd+bS/pkgonCuRaMb/zycb5jQtf4OUz/c1lQKZKSZvmj9lcM76zaD1fsBZw==", "b1617bf8-620c-4dfa-8291-6d5c34cc9a4a" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Genre", "Title" },
                values: new object[] { "Action", "Terminator 2" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "Inception");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "The Matrix");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Genre", "Title" },
                values: new object[] { "Crime", "The Godfather" });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comment", "RatingNumber", "UserId" },
                values: new object[] { "Amazing action, great storyline!", 4, "user1" });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Comment", "RatingNumber", "UserId" },
                values: new object[] { "A classic, but a bit outdated.", 4, "user2" });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Comment", "MovieId", "RatingNumber", "UserId" },
                values: new object[] { "Mind-blowing movie, loved the concept!", 2, 5, "user3" });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Comment", "MovieId", "RatingNumber", "UserId" },
                values: new object[] { "Brilliant, but hard to follow at times.", 2, 4, "user4" });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Comment", "MovieId", "RatingNumber", "UserId" },
                values: new object[] { "A masterpiece of cinema.", 3, 50, "user1" });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Comment", "MovieId", "RatingNumber", "UserId" },
                values: new object[] { "Incredible visuals and action scenes!", 3, 4, "user5" });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Comment", "MovieId", "RatingNumber", "UserId" },
                values: new object[] { "One of the greatest films ever made.", 4, 5, "user6" });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Comment", "MovieId", "RatingNumber", "UserId" },
                values: new object[] { "Amazing storytelling and acting.", 4, 4, "user2" });

            migrationBuilder.InsertData(
                table: "Watchlists",
                columns: new[] { "Id", "AddedDate", "MovieId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 22, 12, 8, 49, 380, DateTimeKind.Local).AddTicks(3166), 1, "user1" },
                    { 2, new DateTime(2024, 11, 27, 12, 8, 49, 380, DateTimeKind.Local).AddTicks(3255), 3, "user1" },
                    { 3, new DateTime(2024, 11, 17, 12, 8, 49, 380, DateTimeKind.Local).AddTicks(3258), 2, "user2" },
                    { 4, new DateTime(2024, 11, 12, 12, 8, 49, 380, DateTimeKind.Local).AddTicks(3260), 4, "user3" },
                    { 5, new DateTime(2024, 11, 7, 12, 8, 49, 380, DateTimeKind.Local).AddTicks(3262), 1, "user4" },
                    { 6, new DateTime(2024, 11, 2, 12, 8, 49, 380, DateTimeKind.Local).AddTicks(3264), 2, "user5" },
                    { 7, new DateTime(2024, 10, 28, 12, 8, 49, 380, DateTimeKind.Local).AddTicks(3271), 4, "user6" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Watchlists_WatchlistId",
                table: "Movies",
                column: "WatchlistId",
                principalTable: "Watchlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
