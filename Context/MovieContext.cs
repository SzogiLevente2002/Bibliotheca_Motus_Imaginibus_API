﻿using Bibliotheca_Motus_Imaginibus_API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bibliotheca_Motus_Imaginibus_API.Context
{
    public class MovieContext : IdentityDbContext<User>
    {
        private readonly string _imageDirectory = @"C:\Users\Asus-01\source\repos\Bibliotheca Motus Imaginibus API\sources";

        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Ratings> Ratings { get; set; }
        public DbSet<Watchlist> Watchlists { get; set; }

        // Kép betöltése byte[] formátumban
        private byte[] LoadImage(string imageName)
        {
            var filePath = Path.Combine(_imageDirectory, $"{imageName}.jpg");
            if (File.Exists(filePath))
            {
                return File.ReadAllBytes(filePath);
            }
            return null;
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<List<string>>().HasNoKey();

            // Alapértelmezett szerep létrehozása
            var userRole = new IdentityRole
            {
                Id = "user-role-id",
                Name = "User",
                NormalizedName = "USER"
            };
            modelBuilder.Entity<IdentityRole>().HasData(userRole);

            // Seed movie data
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Terminátor 2", Director = "James Cameron", ReleasedDate = new DateTime(1991, 8, 16), Genre = "Akció", Length = 137, Actor1 = "Arnold Schwarzenegger", Actor2 = "Linda Hamilton", Actor3 = "Edward Furlong", Description = "A gépek és emberek háborújának közepén a jövőbeli vezető, John Connor, visszaküldi a Terminátort, hogy megvédje a fiatalabb önmagát a gépek elől.", Poster = LoadImage("1"), AddedAt = DateTime.Now },
                new Movie { Id = 2, Title = "Eredet", Director = "Christopher Nolan", ReleasedDate = new DateTime(2010, 7, 16), Genre = "Sci-Fi", Length = 148, Actor1 = "Leonardo DiCaprio", Actor2 = "Joseph Gordon-Levitt", Actor3 = "Ellen Page", Description = "Egy tolvaj, aki képes az emberek álmaiba behatolni, egy utolsó küldetést kap, amely megváltoztatja az emberiség jövőjét.", Poster = LoadImage("2"), AddedAt = DateTime.Now },
                new Movie { Id = 3, Title = "Mátrix", Director = "Lana Wachowski", ReleasedDate = new DateTime(1999, 3, 31), Genre = "Sci-Fi", Length = 136, Actor1 = "Keanu Reeves", Actor2 = "Laurence Fishburne", Actor3 = "Carrie-Anne Moss", Description = "A hacker, Neo, felfedezi, hogy a világ, amiben él, valójában egy mesterségesen generált álom, és elindul a harc a valóság megszerzéséért.", Poster = LoadImage("3"), AddedAt = DateTime.Now },
                new Movie { Id = 4, Title = "A keresztapa", Director = "Francis Ford Coppola", ReleasedDate = new DateTime(1972, 3, 24), Genre = "Krimi", Length = 175, Actor1 = "Marlon Brando", Actor2 = "Al Pacino", Actor3 = "James Caan", Description = "A Corleone család, egy olasz-amerikai maffiacsalád, és annak hatalma, politikai befolyása, valamint a családi kapcsolatok története.", Poster = LoadImage("4"), AddedAt = DateTime.Now },
                new Movie { Id = 5, Title = "A sötét lovag", Director = "Christopher Nolan", ReleasedDate = new DateTime(2008, 7, 18), Genre = "Akció", Length = 152, Actor1 = "Christian Bale", Actor2 = "Heath Ledger", Actor3 = "Aaron Eckhart", Description = "Batman szembesül Jokerrrel, a gonosz nevettetővel, aki a Gotham városában uralkodó káoszt szeretné elérni, miközben saját identitásának és elveinek határait is feszegeti.", Poster = LoadImage("5"), AddedAt = DateTime.Now },
                new Movie { Id = 6, Title = "Ponyvaregény", Director = "Quentin Tarantino", ReleasedDate = new DateTime(1994, 10, 14), Genre = "Krimi", Length = 154, Actor1 = "John Travolta", Actor2 = "Uma Thurman", Actor3 = "Samuel L. Jackson", Description = "Két bérgyilkos napi kalandjait követhetjük, miközben véletlenek és szórakoztató párbeszédek révén kibontakozik egy sötét humorral teli történet.", Poster = LoadImage("6"), AddedAt = DateTime.Now },
                new Movie { Id = 7, Title = "Star Wars: Egy új remény", Director = "George Lucas", ReleasedDate = new DateTime(1977, 5, 25), Genre = "Sci-Fi", Length = 121, Actor1 = "Mark Hamill", Actor2 = "Harrison Ford", Actor3 = "Carrie Fisher", Description = "Luke Skywalker és barátai a Birodalom elleni harc során igyekeznek megsemmisíteni a Halálcsillagot, miközben felfedezik saját erejüket és küldetésüket.", Poster = LoadImage("7"), AddedAt = DateTime.Now },
                new Movie { Id = 8, Title = "A nyolcadik utas: a Halál", Director = "Ridley Scott", ReleasedDate = new DateTime(1979, 5, 25), Genre = "Sci-Fi", Length = 117, Actor1 = "Sigourney Weaver", Actor2 = "Tom Skerritt", Actor3 = "John Hurt", Description = "A Nostromo űrhajó legénysége egy ismeretlen bolygóról hozott idegen lénytől kezd el rettegni, miközben kétségbeesetten próbálnak életben maradni.", Poster = LoadImage("8"), AddedAt = DateTime.Now },
                new Movie { Id = 9, Title = "Gladiátor", Director = "Ridley Scott", ReleasedDate = new DateTime(2000, 5, 5), Genre = "Történelmi", Length = 155, Actor1 = "Russell Crowe", Actor2 = "Joaquin Phoenix", Actor3 = "Connie Nielsen", Description = "Maximus, egy római katona, akit árulás miatt a császári család ellenségei elárulnak, gladiátorként próbál visszavágni a római birodalom hatalmának megdöntéséért.", Poster = LoadImage("9"), AddedAt = DateTime.Now },
                new Movie { Id = 10, Title = "Forrest Gump", Director = "Robert Zemeckis", ReleasedDate = new DateTime(1994, 7, 6), Genre = "Dráma", Length = 142, Actor1 = "Tom Hanks", Actor2 = "Robin Wright", Actor3 = "Gary Sinise", Description = "Forrest Gump története, aki egyszerű elmebeli képességekkel rendelkezik, de életét olyan fontos történelmi események formálják, amelyekkel sokak számára inspirációt ad.", Poster = LoadImage("10"), AddedAt = DateTime.Now },
                new Movie { Id = 11, Title = "A remény rabjai", Director = "Frank Darabont", ReleasedDate = new DateTime(1994, 9, 22), Genre = "Dráma", Length = 142, Actor1 = "Tim Robbins", Actor2 = "Morgan Freeman", Actor3 = "Bob Gunton", Description = "Andy Dufresne, egy bankár ártatlanul letartóztatva, élete végéig a Shawshank börtönben próbál meg túlélni, miközben megőrzi reményét és titkos tervét.", Poster = LoadImage("11"), AddedAt = DateTime.Now },
                new Movie { Id = 12, Title = "Schindler listája", Director = "Steven Spielberg", ReleasedDate = new DateTime(1993, 12, 15), Genre = "Történelmi", Length = 195, Actor1 = "Liam Neeson", Actor2 = "Ben Kingsley", Actor3 = "Ralph Fiennes", Description = "A film Schindler történetét követi, aki a második világháború alatt több mint ezer zsidó életét mentette meg, miközben sikeresen elkerülte a náci hatóságok figyelmét.", Poster = LoadImage("12"), AddedAt = DateTime.Now },
                new Movie { Id = 13, Title = "A tégla", Director = "Martin Scorsese", ReleasedDate = new DateTime(2006, 10, 6), Genre = "Krimi", Length = 151, Actor1 = "Leonardo DiCaprio", Actor2 = "Matt Damon", Actor3 = "Jack Nicholson", Description = "Billy Costigan, egy fiatal rendőr, beépül a bostoni maffiába, miközben a maffia ügyeiért dolgozó Colin Sullivan titkosszolgálati informátorként segíti a bűnözőket.", Poster = LoadImage("13"), AddedAt = DateTime.Now },
                new Movie { Id = 14, Title = "Django elszabadul", Director = "Quentin Tarantino", ReleasedDate = new DateTime(2012, 12, 25), Genre = "Western", Length = 165, Actor1 = "Jamie Foxx", Actor2 = "Christoph Waltz", Actor3 = "Leonardo DiCaprio", Description = "Django, egy felszabadított rabszolga, szövetséget köt egy német fejvadásszal, hogy megmentsen feleségét, és igazságot szolgáltasson egy brutális rabszolga-kereskedőnek.", Poster = LoadImage("14"), AddedAt = DateTime.Now },
                new Movie { Id = 15, Title = "A vadnyugat hőskora", Director = "Sergio Leone", ReleasedDate = new DateTime(1968, 12, 21), Genre = "Western", Length = 165, Actor1 = "Clint Eastwood", Actor2 = "Lee Van Cleef", Actor3 = "Eli Wallach", Description = "A film három különböző férfi keresztutjait követi, akik a vadnyugat törvényei szerint küzdenek a túlélésért, miközben egy hatalmas bűnügyi összeesküvésben vesznek részt.", Poster = LoadImage("15"), AddedAt = DateTime.Now },
                new Movie { Id = 16, Title = "Titanic", Director = "James Cameron", ReleasedDate = new DateTime(1997, 12, 19), Genre = "Romantikus", Length = 195, Actor1 = "Leonardo DiCaprio", Actor2 = "Kate Winslet", Actor3 = "Billy Zane", Description = "Jack és Rose szerelmének története, akik egy tragikus sorsú hajón, a Titanic fedélzetén találkoznak és élnek át mindent, ami a sors által nekik kijut.", Poster = LoadImage("16"), AddedAt = DateTime.Now },
                new Movie { Id = 17, Title = "Szerelmünk lapjai", Director = "Nick Cassavetes", ReleasedDate = new DateTime(2004, 6, 25), Genre = "Romantikus", Length = 123, Actor1 = "Ryan Gosling", Actor2 = "Rachel McAdams", Actor3 = "James Garner", Description = "Noah és Allie szerelme, mely hosszú évek után sem halványul el, miközben két különböző világ találkozik és a szeretet mindent legyőz.", Poster = LoadImage("17"), AddedAt = DateTime.Now },
                new Movie { Id = 18, Title = "Szellemirtók", Director = "Ivan Reitman", ReleasedDate = new DateTime(1984, 6, 8), Genre = "Vígjáték", Length = 105, Actor1 = "Bill Murray", Actor2 = "Dan Aykroyd", Actor3 = "Sigourney Weaver", Description = "Három tudós és egy szellemirtó csoport létrehozása, akik New York városában az emelkedő szellemeket és paranormális jelenségeket kezdik el üldözni.", Poster = LoadImage("18"), AddedAt = DateTime.Now },
                new Movie { Id = 19, Title = "Nagy durranás", Director = "Jim Abrahams", ReleasedDate = new DateTime(1991, 7, 31), Genre = "Vígjáték", Length = 84, Actor1 = "John Candy", Actor2 = "Joe Flaherty", Actor3 = "Harold Ramis", Description = "Két bűnöző, akik nemcsak az igazságszolgáltatás elől menekülnek, hanem saját szörnyű döntéseik következményeivel is küzdenek egy hatalmas vígjátékban.", Poster = LoadImage("19"), AddedAt = DateTime.Now },
                new Movie { Id = 20, Title = "Ace Ventura: Állati nyomozó", Director = "Tom Shadyac", ReleasedDate = new DateTime(1994, 2, 4), Genre = "Vígjáték", Length = 86, Actor1 = "Jim Carrey", Actor2 = "Courtney Cox", Actor3 = "Sean Young", Description = "Ace Ventura, egy szórakoztató és zűrös állati nyomozó, aki segít visszaszerezni egy eltűnt delfint, miközben elképesztő kalandokon megy keresztül.", Poster = LoadImage("20"), AddedAt = DateTime.Now },
                new Movie { Id = 21, Title = "Rémálom az Elm utcában", Director = "Wes Craven", ReleasedDate = new DateTime(1984, 11, 9), Genre = "Horror", Length = 91, Actor1 = "Heather Langenkamp", Actor2 = "Johnny Depp", Actor3 = "Robert Englund", Description = "Freddy Krueger, a szörnyű álmok gyilkosa visszatér, hogy a fiatalokat egy rémálomban elpusztítsa, miközben ők próbálják kideríteni, hogyan állíthatják meg őt.", Poster = LoadImage("21"), AddedAt = DateTime.Now },
                new Movie { Id = 22, Title = "Az ördögűző", Director = "William Friedkin", ReleasedDate = new DateTime(1973, 12, 26), Genre = "Horror", Length = 122, Actor1 = "Ellen Burstyn", Actor2 = "Max von Sydow", Actor3 = "Linda Blair", Description = "A fiatal Regan MacNeil-t egy gonosz démon szállja meg, és egy pap segítségét kérik, hogy kiűzzék a démoni jelenlétet, miközben a szülők kétségbeesetten küzdenek.", Poster = LoadImage("22"), AddedAt = DateTime.Now },
                new Movie { Id = 23, Title = "Halloween", Director = "John Carpenter", ReleasedDate = new DateTime(1978, 10, 25), Genre = "Horror", Length = 91, Actor1 = "Jamie Lee Curtis", Actor2 = "Donald Pleasence", Actor3 = "Tony Moran", Description = "Michael Myers, a gyilkos, aki elmenekült egy pszichiátriai intézetből, hogy folytassa az áldozatok sorozatát Halloween éjszakáján, miközben Laurie Strode próbál túlélni.", Poster = LoadImage("23"), AddedAt = DateTime.Now },
                new Movie { Id = 24, Title = "Péntek 13.", Director = "Sean S. Cunningham", ReleasedDate = new DateTime(1980, 5, 9), Genre = "Horror", Length = 95, Actor1 = "Betsy Palmer", Actor2 = "Adrienne King", Actor3 = "Harry Manfredini", Description = "A Crystal Lake kempingezői sorozatos gyilkosságokat tapasztalnak, miközben egy rejtélyes gyilkos, Jason Voorhees újra és újra támadja őket.", Poster = LoadImage("24"), AddedAt = DateTime.Now },
                new Movie { Id = 25, Title = "Interstellar", Director = "Christopher Nolan", ReleasedDate = new DateTime(2014, 11, 7), Genre = "Sci-Fi", Length = 169, Actor1 = "Matthew McConaughey", Actor2 = "Anne Hathaway", Actor3 = "Jessica Chastain", Description = "A Föld elpusztulása előtt egy csapat űrhajós a galaxisba indul, hogy egy új otthont találjon az emberiség számára, miközben mélyen elgondolkodtató kérdéseket vetnek fel az időről és a szeretetről.", Poster = LoadImage("25"), AddedAt = DateTime.Now },
                new Movie { Id = 26, Title = "A visszatérő", Director = "Alejandro G. Iñárritu", ReleasedDate = new DateTime(2015, 12, 25), Genre = "Kaland", Length = 156, Actor1 = "Leonardo DiCaprio", Actor2 = "Tom Hardy", Actor3 = "Domhnall Gleeson", Description = "Hugh Glass, egy vadász, akit egy medve súlyosan megsebesít, és úgy hagynak, hogy meghaljon, visszavág és igyekszik túlélni a vadonban, miközben bosszút esküszik az őt cserbenhagyó társai ellen.", Poster = LoadImage("26"), AddedAt = DateTime.Now },
                new Movie { Id = 27, Title = "A gyűrűk ura: A király visszatér", Director = "Peter Jackson", ReleasedDate = new DateTime(2003, 12, 17), Genre = "Kaland", Length = 201, Actor1 = "Elijah Wood", Actor2 = "Ian McKellen", Actor3 = "Viggo Mortensen", Description = "A háború végső csatája kezdődik, miközben Frodo és Sam közel járnak a Sötét Úr, Sauron megsemmisítéséhez, miközben Aragorn és a Szövetség a háborúban harcol.", Poster = LoadImage("27"), AddedAt = DateTime.Now },
                new Movie { Id = 28, Title = "Harry Potter és a bölcsek köve", Director = "Chris Columbus", ReleasedDate = new DateTime(2001, 11, 16), Genre = "Kaland", Length = 152, Actor1 = "Daniel Radcliffe", Actor2 = "Rupert Grint", Actor3 = "Emma Watson", Description = "Harry Potter felfedezi, hogy ő egy varázsló, és elindul a mágikus világban, miközben barátaival egy misztikus kő nyomában járnak, hogy megakadályozzák a sötét varázsló visszatérését.", Poster = LoadImage("28"), AddedAt = DateTime.Now },
                new Movie { Id = 29, Title = "Indiana Jones és az elveszett frigyláda fosztogatói", Director = "Steven Spielberg", ReleasedDate = new DateTime(1981, 6, 12), Genre = "Kaland", Length = 115, Actor1 = "Harrison Ford", Actor2 = "Karen Allen", Actor3 = "Paul Freeman", Description = "Indiana Jones, a kalandor régész, megpróbálja megelőzni a nácikat, akik az elveszett frigyládát keresik, egy titkos ereklyét, amely hatalmas hatalommal bír.", Poster = LoadImage("29"), AddedAt = DateTime.Now },
                new Movie { Id = 30, Title = "Egy csodálatos elme", Director = "Ron Howard", ReleasedDate = new DateTime(2001, 12, 21), Genre = "Dráma", Length = 135, Actor1 = "Russell Crowe", Actor2 = "Jennifer Connelly", Actor3 = "Ed Harris", Description = "John Nash, a zseniális matematikus, a skizofréniával küzd, miközben próbálja megérteni a saját elméjét, és harcol a belső démonokkal, hogy megtartsa a karrierjét és a szerelmét.", Poster = LoadImage("30"), AddedAt = DateTime.Now },
                new Movie { Id = 31, Title = "Whiplash", Director = "Damien Chazelle", ReleasedDate = new DateTime(2014, 10, 10), Genre = "Dráma", Length = 106, Actor1 = "Miles Teller", Actor2 = "J.K. Simmons", Actor3 = "Melissa Benoist", Description = "Andrew, egy fiatal dobos, mindent feláldoz, hogy elérje álmait, miközben egy szigorú és manipulatív tanár, Fletcher próbálja elérni, hogy a legjobbat hozza ki belőle.", Poster = LoadImage("31"), AddedAt = DateTime.Now },
                new Movie { Id = 32, Title = "Szárnyas fejvadász", Director = "Ridley Scott", ReleasedDate = new DateTime(1982, 6, 25), Genre = "Sci-Fi", Length = 117, Actor1 = "Harrison Ford", Actor2 = "Rutger Hauer", Actor3 = "Sean Young", Description = "Rick Deckard, egy szárnyas fejvadász, aki egy újabb gyilkos androidot kell, hogy levadásszon, kétségbeesetten keres egy igazságot egy világban, amelyben a gépek és az emberek közötti határok elmosódnak.", Poster = LoadImage("32"), AddedAt = DateTime.Now },
                new Movie { Id = 33, Title = "A hihetetlen Hulk", Director = "Louis Leterrier", ReleasedDate = new DateTime(2008, 6, 13), Genre = "Akció", Length = 112, Actor1 = "Edward Norton", Actor2 = "Liv Tyler", Actor3 = "Tim Roth", Description = "Bruce Banner, aki tudatosan próbálja megállítani a szörnyű szörnyeteg Hulkot, miután egy kísérlet következtében folyamatosan mutálódik, miközben el akarja kerülni, hogy a katonai hatalom elfogja őt.", Poster = LoadImage("33"), AddedAt = DateTime.Now },
                new Movie { Id = 34, Title = "KicsiKÉM – Austin Powers 2.", Director = "Jay Roach", ReleasedDate = new DateTime(1999, 6, 8), Genre = "Vígjáték", Length = 95, Actor1 = "Mike Myers", Actor2 = "Beyoncé Knowles", Actor3 = "Vernon Troyer", Description = "Austin Powers, a híres brit titkos ügynök, visszatér, hogy megakadályozza a gonosz Dr. Evil tervét, miközben a nevetés határain túl is szórakoztatja a közönséget.", Poster = LoadImage("34"), AddedAt = DateTime.Now },
                new Movie { Id = 35, Title = "A magányos lovas", Director = "Gore Verbinski", ReleasedDate = new DateTime(2013, 7, 3), Genre = "Western", Length = 149, Actor1 = "Johnny Depp", Actor2 = "Armie Hammer", Actor3 = "Tom Wilkinson", Description = "A vadnyugat határain túl egy különös kettős kapcsolat alakul ki: a titokzatos Lone Ranger és Tonto, az indián kísérője, hogy felvegyék a harcot a korrupt erőkkel.", Poster = LoadImage("35"), AddedAt = DateTime.Now },
                new Movie { Id = 36, Title = "Fekete Párduc", Director = "Ryan Coogler", ReleasedDate = new DateTime(2018, 2, 16), Genre = "Akció", Length = 134, Actor1 = "Chadwick Boseman", Actor2 = "Michael B. Jordan", Actor3 = "Lupita Nyong'o", Description = "T'Challa, Wakanda királya és új Fekete Párduc, szembesül egy nagy hatalmú ellenséggel, aki megpróbálja felfedni országát és kihasználni annak gazdagságát.", Poster = LoadImage("36"), AddedAt = DateTime.Now },
                new Movie { Id = 37, Title = "Deadpool", Director = "Tim Miller", ReleasedDate = new DateTime(2016, 2, 12), Genre = "Akció", Length = 108, Actor1 = "Ryan Reynolds", Actor2 = "Morena Baccarin", Actor3 = "T.J. Miller", Description = "Wade Wilson, egy egykori különleges erőket végző katona, akit kísérletezéssel alakítanak át, hogy megszerezze gyógyító képességét, és harcba száll a bűnözőkkel.", Poster = LoadImage("37"), AddedAt = DateTime.Now },
                new Movie { Id = 38, Title = "Logan", Director = "James Mangold", ReleasedDate = new DateTime(2017, 3, 3), Genre = "Akció", Length = 137, Actor1 = "Hugh Jackman", Actor2 = "Patrick Stewart", Actor3 = "Dafne Keen", Description = "Logan, az öreg és beteg X-Men tag, segít egy fiatal mutantot elmenekülni, miközben harcol saját szellemi és fizikai határain túl.", Poster = LoadImage("38"), AddedAt = DateTime.Now },
                new Movie { Id = 39, Title = "Batman v Superman: Az igazság hajnal", Director = "Zack Snyder", ReleasedDate = new DateTime(2016, 3, 25), Genre = "Akció", Length = 151, Actor1 = "Ben Affleck", Actor2 = "Henry Cavill", Actor3 = "Gal Gadot", Description = "Batman és Superman összecsapása, miközben mindketten próbálják megérteni, miért kell harcolniuk, miközben a világot egy új fenyegetés is veszélyezteti.", Poster = LoadImage("39"), AddedAt = DateTime.Now },
                new Movie { Id = 40, Title = "Deadpool 2", Director = "David Leitch", ReleasedDate = new DateTime(2018, 5, 18), Genre = "Akció", Length = 119, Actor1 = "Ryan Reynolds", Actor2 = "Josh Brolin", Actor3 = "Zazie Beetz", Description = "Deadpool visszatér, hogy egy új csapatot toborozzon, miközben harcol a világot fenyegető gonosz erőkkel, és megpróbálja felfedezni saját személyiségét.", Poster = LoadImage("40"), AddedAt = DateTime.Now },
                new Movie { Id = 41, Title = "Stranger Things", Director = "The Duffer Brothers", ReleasedDate = new DateTime(2016, 7, 15), Genre = "Horror, Sci-Fi", Length = 50, Actor1 = "Winona Ryder", Actor2 = "David Harbour", Actor3 = "Millie Bobby Brown", Description = "Egy kisvárosban, Hawkinsban, különös események kezdődnek el, miután egy fiú eltűnik, és egy titokzatos lány jelenik meg, aki különleges képességekkel rendelkezik.", Poster = LoadImage("41"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 5, NumberOfEpisodes = 40 },
                new Movie { Id = 42, Title = "Game of Thrones", Director = "David Benioff, D.B. Weiss", ReleasedDate = new DateTime(2011, 4, 17), Genre = "Fantasy, Drama", Length = 60, Actor1 = "Emilia Clarke", Actor2 = "Kit Harington", Actor3 = "Peter Dinklage", Description = "A különböző házak harcolnak a Trónok harca során, miközben a világot fenyegető titokzatos erő egyre közelebb kerül.", Poster = LoadImage("42"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 8, NumberOfEpisodes = 73 },
                new Movie { Id = 43, Title = "Breaking Bad", Director = "Vince Gilligan", ReleasedDate = new DateTime(2008, 1, 20), Genre = "Crime, Drama, Thriller", Length = 47, Actor1 = "Bryan Cranston", Actor2 = "Aaron Paul", Actor3 = "Anna Gunn", Description = "Egy középiskolai kémiatanár rákos betegségből kifolyólag egy bűnözői világba lép, hogy biztosítja családja jövőjét.", Poster = LoadImage("43"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 5, NumberOfEpisodes = 62 },
                new Movie { Id = 44, Title = "The Witcher", Director = "Lauren Schmidt Hissrich", ReleasedDate = new DateTime(2019, 12, 20), Genre = "Action, Adventure, Drama", Length = 60, Actor1 = "Henry Cavill", Actor2 = "Anya Chalotra", Actor3 = "Freya Allan", Description = "Geralt of Rivia, a szörnyvadász egy elragadó világban navigál, miközben titokzatos erők és politikai játszmák sodorják a történet fonalát.", Poster = LoadImage("44"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 2, NumberOfEpisodes = 16 },
                new Movie { Id = 45, Title = "The Mandalorian", Director = "Jon Favreau", ReleasedDate = new DateTime(2019, 11, 12), Genre = "Action, Adventure, Fantasy", Length = 40, Actor1 = "Pedro Pascal", Actor2 = "Gina Carano", Actor3 = "Carl Weathers", Description = "A történet egy mandalóri harcos körül forog, aki galaxisok között vándorol, miközben megpróbálja megvédeni egy rejtélyes, erővel rendelkező gyermeket.", Poster = LoadImage("45"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 3, NumberOfEpisodes = 24 },
                new Movie { Id = 46, Title = "Money Heist", Director = "Álex Pina", ReleasedDate = new DateTime(2017, 5, 2), Genre = "Action, Crime, Drama", Length = 50, Actor1 = "Úrsula Corberó", Actor2 = "Álvaro Morte", Actor3 = "Itziar Ituño", Description = "Egy titokzatos férfi és csapata különböző bankokat rabol ki, miközben az egész világ szeme rajtuk van.", Poster = LoadImage("46"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 5, NumberOfEpisodes = 48 },
                new Movie { Id = 47, Title = "The Crown", Director = "Peter Morgan", ReleasedDate = new DateTime(2016, 11, 4), Genre = "Biography, Drama, History", Length = 60, Actor1 = "Claire Foy", Actor2 = "Matt Smith", Actor3 = "Vanessa Kirby", Description = "A brit királyi család életét követi nyomon, különös figyelmet fordítva II. Erzsébet uralkodására és a hozzá kapcsolódó politikai eseményekre.", Poster = LoadImage("47"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 6, NumberOfEpisodes = 60 },
                new Movie { Id = 48, Title = "The Boys", Director = "Eric Kripke", ReleasedDate = new DateTime(2019, 7, 26), Genre = "Action, Comedy, Crime", Length = 60, Actor1 = "Karl Urban", Actor2 = "Jack Quaid", Actor3 = "Antony Starr", Description = "A szuperhősök világát követi, de ezek nem azok a hősök, akikről álmodtunk. A ‘Boys’ egy csapat, amely felkészül arra, hogy megállítsa a veszélyes szuperhősöket.", Poster = LoadImage("48"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 3, NumberOfEpisodes = 24 },
                new Movie { Id = 49, Title = "Dark", Director = "Baran bo Odar", ReleasedDate = new DateTime(2017, 12, 1), Genre = "Drama, Mystery, Sci-Fi", Length = 60, Actor1 = "Louis Hofmann", Actor2 = "Oliver Masucci", Actor3 = "Maja Schöne", Description = "A történet egy kis német városban játszódik, ahol eltűnések és időutazás kezd el felfedni titkokat a múltból és a jövőből.", Poster = LoadImage("49"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 3, NumberOfEpisodes = 26 },
                new Movie { Id = 50, Title = "Narcos", Director = "Chris Brancato, Carlo Bernard, Doug Miro", ReleasedDate = new DateTime(2015, 8, 28), Genre = "Biography, Crime, Drama", Length = 60, Actor1 = "Wagner Moura", Actor2 = "Pedro Pascal", Actor3 = "Boyd Holbrook", Description = "A kolumbiai drogkartell és a rendőrség harcát követi nyomon, miközben a bűnözői világ titkai és hatalmi játszmái is kibontakoznak.", Poster = LoadImage("50"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 3, NumberOfEpisodes = 30 },
                new Movie { Id = 51, Title = "Sherlock", Director = "Steven Moffat, Mark Gatiss", ReleasedDate = new DateTime(2010, 7, 25), Genre = "Krimi, Dráma", Length = 90, Actor1 = "Benedict Cumberbatch", Actor2 = "Martin Freeman", Actor3 = "Andrew Scott", Description = "A híres detektív, Sherlock Holmes modern feldolgozása Londonban, különleges nyomozásokkal.", Poster = LoadImage("51"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 4, NumberOfEpisodes = 13 },
                new Movie { Id = 52, Title = "Friends", Director = "David Crane, Marta Kauffman", ReleasedDate = new DateTime(1994, 9, 22), Genre = "Vígjáték, Romantikus", Length = 22, Actor1 = "Jennifer Aniston", Actor2 = "Courteney Cox", Actor3 = "Matt LeBlanc", Description = "Hat barát életének humoros és érzelmes pillanatai New York City-ben.", Poster = LoadImage("52"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 10, NumberOfEpisodes = 236 },
                new Movie { Id = 53, Title = "The Haunting of Hill House", Director = "Mike Flanagan", ReleasedDate = new DateTime(2018, 10, 12), Genre = "Horror, Dráma", Length = 50, Actor1 = "Victoria Pedretti", Actor2 = "Oliver Jackson-Cohen", Actor3 = "Carla Gugino", Description = "Egy család múltját és jelenét összekapcsoló kísértetjárta ház története.", Poster = LoadImage("53"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 1, NumberOfEpisodes = 10 },
                new Movie { Id = 54, Title = "Peaky Blinders", Director = "Steven Knight", ReleasedDate = new DateTime(2013, 9, 12), Genre = "Krimi, Dráma", Length = 55, Actor1 = "Cillian Murphy", Actor2 = "Helen McCrory", Actor3 = "Paul Anderson", Description = "A Shelby család bűnszervezetének története az 1920-as évek Birminghamben.", Poster = LoadImage("54"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 6, NumberOfEpisodes = 36 },
                new Movie { Id = 55, Title = "The Office (US)", Director = "Greg Daniels", ReleasedDate = new DateTime(2005, 3, 24), Genre = "Vígjáték", Length = 22, Actor1 = "Steve Carell", Actor2 = "Rainn Wilson", Actor3 = "John Krasinski", Description = "Egy papírgyár dolgozóinak mindennapjai humoros, szatirikus feldolgozásban.", Poster = LoadImage("55"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 9, NumberOfEpisodes = 201 },
                new Movie { Id = 56, Title = "Outlander", Director = "Ronald D. Moore", ReleasedDate = new DateTime(2014, 8, 9), Genre = "Romantikus, Fantasztikus, Dráma", Length = 60, Actor1 = "Caitríona Balfe", Actor2 = "Sam Heughan", Actor3 = "Tobias Menzies", Description = "Egy időutazó ápolónő története, aki egy 1743-as skót felkelés közepén találja magát.", Poster = LoadImage("56"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 7, NumberOfEpisodes = 75 },
                new Movie { Id = 57, Title = "Fargo", Director = "Noah Hawley", ReleasedDate = new DateTime(2014, 4, 15), Genre = "Krimi, Dráma, Thriller", Length = 55, Actor1 = "Billy Bob Thornton", Actor2 = "Martin Freeman", Actor3 = "Allison Tolman", Description = "A híres film alapján készült antológiasorozat különböző bűncselekményekről és következményeikről.", Poster = LoadImage("57"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 5, NumberOfEpisodes = 51 },
                new Movie { Id = 58, Title = "The Expanse", Director = "Mark Fergus, Hawk Ostby", ReleasedDate = new DateTime(2015, 12, 14), Genre = "Sci-Fi, Dráma, Thriller", Length = 45, Actor1 = "Steven Strait", Actor2 = "Dominique Tipper", Actor3 = "Wes Chatham", Description = "Egy jövőbeli világban játszódó történet, ahol az emberiség a Földön, Marson és az aszteroidaövben él, és egy rejtélyes fenyegetéssel néz szembe.", Poster = LoadImage("58"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 6, NumberOfEpisodes = 62 },
                new Movie { Id = 59, Title = "Black Mirror", Director = "Charlie Brooker", ReleasedDate = new DateTime(2011, 12, 4), Genre = "Sci-Fi, Thriller, Dráma", Length = 60, Actor1 = "Bryce Dallas Howard", Actor2 = "Daniel Kaluuya", Actor3 = "Jon Hamm", Description = "Antológiasorozat, amely a modern technológia és a társadalom kapcsolatának sötét, néha groteszk oldalát mutatja be.", Poster = LoadImage("59"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 6, NumberOfEpisodes = 27 },
                new Movie { Id = 60, Title = "Yellowstone", Director = "Taylor Sheridan", ReleasedDate = new DateTime(2018, 6, 20), Genre = "Western, Dráma", Length = 45, Actor1 = "Kevin Costner", Actor2 = "Kelly Reilly", Actor3 = "Luke Grimes", Description = "A Dutton család földbirtoklásért folytatott harca Montanában.", Poster = LoadImage("60"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 5, NumberOfEpisodes = 50 },
                new Movie { Id = 61, Title = "The Big Bang Theory", Director = "Chuck Lorre, Bill Prady", ReleasedDate = new DateTime(2007, 9, 24), Genre = "Vígjáték, Romantikus", Length = 22, Actor1 = "Jim Parsons", Actor2 = "Johnny Galecki", Actor3 = "Kaley Cuoco", Description = "Egy tudóscsoport mindennapjai humoros helyzetekkel és romantikus fordulatokkal.", Poster = LoadImage("61"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 12, NumberOfEpisodes = 279 },
                new Movie { Id = 62, Title = "The Walking Dead", Director = "Frank Darabont", ReleasedDate = new DateTime(2010, 10, 31), Genre = "Horror, Kaland, Dráma", Length = 60, Actor1 = "Andrew Lincoln", Actor2 = "Norman Reedus", Actor3 = "Melissa McBride", Description = "Egy zombiapokalipszis túlélőinek küzdelme az életért és emberi kapcsolatokért.", Poster = LoadImage("62"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 11, NumberOfEpisodes = 177 },
                new Movie { Id = 63, Title = "True Detective", Director = "Nic Pizzolatto", ReleasedDate = new DateTime(2014, 1, 12), Genre = "Krimi, Dráma, Thriller", Length = 55, Actor1 = "Matthew McConaughey", Actor2 = "Woody Harrelson", Actor3 = "Mahershala Ali", Description = "Egy antológiasorozat a detektívek sötét és bonyolult ügyeiről.", Poster = LoadImage("63"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 4, NumberOfEpisodes = 36 },
                new Movie { Id = 64, Title = "The English", Director = "Hugo Blick", ReleasedDate = new DateTime(2022, 11, 11), Genre = "Western, Dráma", Length = 60, Actor1 = "Emily Blunt", Actor2 = "Chaske Spencer", Actor3 = "Rafe Spall", Description = "Egy brit nő és egy indián vadnyugaton találkoznak, hogy közösen kutassák fel a férfi elveszett fiát, miközben a múlt sötét titkai kísértik őket.", Poster = LoadImage("67"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 1, NumberOfEpisodes = 6 },
                new Movie { Id = 65, Title = "Godless", Director = "Scott Frank", ReleasedDate = new DateTime(2017, 11, 22), Genre = "Western, Dráma", Length = 60, Actor1 = "Jeff Daniels", Actor2 = "Michelle Dockery", Actor3 = "Jack O'Connell", Description = "Egy kisváros, amelyet a férfiak és bűnözők tettek elpusztíthatatlanná, most egy női közösség próbálja életben tartani a törvényt.", Poster = LoadImage("68"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 1, NumberOfEpisodes = 7 },
                new Movie { Id = 66, Title = "The Magnificent Seven", Director = "John Sturges", ReleasedDate = new DateTime(1959, 10, 23), Genre = "Western, Kaland, Akció", Length = 60, Actor1 = "Yul Brynner", Actor2 = "Steve McQueen", Actor3 = "Charles Bronson", Description = "Hét bátor férfi összefog, hogy megvédjen egy mexikói falut a kegyetlen banditáktól.", Poster = LoadImage("69"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 1, NumberOfEpisodes = 16 },
                new Movie { Id = 67, Title = "The Rebel", Director = "Arthur Lubin", ReleasedDate = new DateTime(1959, 9, 16), Genre = "Western, Dráma", Length = 30, Actor1 = "Nick Adams", Actor2 = "Olivia de Havilland", Actor3 = "Michael Dante", Description = "Egy kalandor története, aki a vadnyugaton próbálja megtalálni a helyét és küzdeni az igazságért.", Poster = LoadImage("70"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 1, NumberOfEpisodes = 36 },
                new Movie { Id = 68, Title = "Bonanza", Director = "David Dortort", ReleasedDate = new DateTime(1959, 9, 12), Genre = "Western, Dráma", Length = 60, Actor1 = "Lorne Greene", Actor2 = "Pernell Roberts", Actor3 = "Dan Blocker", Description = "A Cartwright család története, akik a nevadai Ponderosa ranchon élik mindennapi életüket és szembenéznek a vadnyugat kihívásaival.", Poster = LoadImage("71"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 14, NumberOfEpisodes = 431 },
                new Movie { Id = 69, Title = "The High Chaparral", Director = "David Dortort", ReleasedDate = new DateTime(1967, 9, 10), Genre = "Western, Dráma", Length = 60, Actor1 = "Leif Erickson", Actor2 = "Cameron Mitchell", Actor3 = "Henry Darrow", Description = "A Big Horn-ranch családja, akik a mexikói határ közelében élnek, mindennapi küzdelmeikkel és a vadnyugat veszélyeivel.", Poster = LoadImage("72"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 4, NumberOfEpisodes = 98 },
                new Movie { Id = 70, Title = "Rawhide", Director = "Charles Marquis Warren", ReleasedDate = new DateTime(1959, 1, 9), Genre = "Western, Kaland", Length = 60, Actor1 = "Clint Eastwood", Actor2 = "Eric Fleming", Actor3 = "Sheb Wooley", Description = "A történet egy marhapásztor csoportról, akik próbálják átvészelni a vadnyugati élet nehézségeit és a mindennapi kalandokat.", Poster = LoadImage("73"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 8, NumberOfEpisodes = 217 },
                new Movie { Id = 71, Title = "Wanted: Dead or Alive", Director = "Sam Peckinpah", ReleasedDate = new DateTime(1958, 9, 6), Genre = "Western, Akció", Length = 30, Actor1 = "Steve McQueen", Actor2 = "Vaughn Taylor", Actor3 = "Robert Carson", Description = "Josh Randall, a vadászó fejvadász története, aki mindenféle bűnözőt és haramiát keres a vadnyugaton.", Poster = LoadImage("74"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 3, NumberOfEpisodes = 94 },
                new Movie { Id = 72, Title = "The Wild Wild West", Director = "Michael Garrison", ReleasedDate = new DateTime(1965, 9, 17), Genre = "Western, Sci-Fi, Kaland", Length = 60, Actor1 = "Robert Conrad", Actor2 = "Ross Martin", Actor3 = "Michael Dunn", Description = "Két titkos ügynök kalandjai a vadnyugaton, akik szembenéznek a legkülönbözőbb fenyegetésekkel és bűnözőkkel.", Poster = LoadImage("75"), AddedAt = DateTime.Now, IsSeries = true, NumberOfSeasons = 4, NumberOfEpisodes = 104 }


                );



            var passwordHasher = new PasswordHasher<User>();

            var users = new List<User>();
            for (int i = 1; i <= 25; i++)
            {
                var user = new User
                {
                    Id = $"user{i}", // Egyedi ID
                    UserName = $"user{i}",
                    NormalizedUserName = $"USER{i}",
                    Email = $"user{i}@example.com",
                    NormalizedEmail = $"USER{i}@EXAMPLE.COM",
                    EmailConfirmed = true,
                    FirstName = $"FirstName{i}",
                    LastName = $"LastName{i}"
                };
                user.PasswordHash = passwordHasher.HashPassword(user, "Password123!");
                users.Add(user);
            }

            // Hozzáadjuk a felhasználókat az adatbázis modelhez
            modelBuilder.Entity<User>().HasData(users);

            // Felhasználó-szerep kapcsolat (minden felhasználó a "User" szerepkörben)
            var userRoles = users.Select(user => new IdentityUserRole<string>
            {
                UserId = user.Id,
                RoleId = "user-role-id"
            }).ToList();

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);

            var ratings = new List<Ratings>();

            var random = new Random();
            var comments = new List<string>
{
    "Nagyszerű film, nagyon élveztem!",
    "Kicsit lassú volt a tempó, de összességében jó.",
    "Lenyűgöző látványvilág és remek színészi játék!",
    "Nem igazán az én ízlésem, de értem miért szeretik.",
    "Hihetetlen történet, teljesen magával ragadott!",
    "Kissé kiszámítható, de azért szórakoztató.",
    "A karakterek nagyon jól kidolgozottak.",
    "Valóban mestermű, mindenkinek ajánlom!",
    "Sokkal jobb, mint amire számítottam.",
    "Egyszerűen fantasztikus, nem tudom eléggé dicsérni!"
};

            int idCounter = 1;

            for (int movieId = 1; movieId <= 40; movieId++)
            {
                var userIds = new List<string> { "user1", "user2", "user3", "user4", "user5", "user6",
                                                 "user7", "user8", "user9", "user10", "user11", "user12",
                                                 "user13", "user14", "user15", "user16", "user17", "user18",
                                                 "user19", "user20", "user21", "user22", "user23", "user24", "user25"
                                                            };
                for (int i = 0; i < 4; i++) // 4 rating per movie
                {
                    var userId = userIds[random.Next(userIds.Count)];
                    userIds.Remove(userId); // Ensure no duplicate ratings from the same user per movie

                    var rating = new Ratings
                    {
                        Id = idCounter++,
                        RatingNumber = random.Next(1, 6), // Random rating between 1 and 5
                        MovieId = movieId,
                        UserId = userId,
                        Comment = comments[random.Next(comments.Count)]
                    };
                    ratings.Add(rating);
                }
            }

            modelBuilder.Entity<Ratings>().HasData(ratings);

            // Watchlist adatok seedelése
            // modelBuilder.Entity<Watchlist>().HasData(
            //     new Watchlist { Id = 1, UserId = "user1", MovieId = 1, AddedDate = DateTime.Now.AddDays(-10) },
            //     new Watchlist { Id = 2, UserId = "user1", MovieId = 3, AddedDate = DateTime.Now.AddDays(-5) },
            //     new Watchlist { Id = 3, UserId = "user2", MovieId = 2, AddedDate = DateTime.Now.AddDays(-15) },
            //     new Watchlist { Id = 4, UserId = "user3", MovieId = 4, AddedDate = DateTime.Now.AddDays(-20) },
            //     new Watchlist { Id = 5, UserId = "user4", MovieId = 1, AddedDate = DateTime.Now.AddDays(-25) },
            //     new Watchlist { Id = 6, UserId = "user5", MovieId = 2, AddedDate = DateTime.Now.AddDays(-30) },
            //     new Watchlist { Id = 7, UserId = "user6", MovieId = 4, AddedDate = DateTime.Now.AddDays(-35) }
            // );

        }

    }
}