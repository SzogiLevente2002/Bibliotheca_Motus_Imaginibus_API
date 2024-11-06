namespace Bibliotheca_Motus_Imaginibus_API.Entities
{
    public class Watchlist 
    {
        public int Id { get; set; }

        public List<Movie> Movies { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
