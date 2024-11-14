using System.Text.Json.Serialization;

namespace Bibliotheca_Motus_Imaginibus_API.Entities
{
    public class Watchlist
    {
        public int Id { get; set; }

        public List<Movie> Movies { get; set; }

        public string UserId { get; set; }  

        [JsonIgnore]
        public User User { get; set; }
    }
}
