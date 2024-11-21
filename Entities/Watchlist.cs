using System.Text.Json.Serialization;

namespace Bibliotheca_Motus_Imaginibus_API.Entities
{
    public class Watchlist
    {
        public int Id { get; set; }

        // Az ICollection típus jobb az EF számára
        public ICollection<Movie>? Movies { get; set; }

        // Felhasználó azonosítója
        public string UserId { get; set; }

        [JsonIgnore]
        // Navigációs tulajdonság a felhasználóhoz
        public User? User { get; set; }
        public DateTime AddedDate { get; internal set; }
        public int MovieId { get; internal set; }
    }
}
