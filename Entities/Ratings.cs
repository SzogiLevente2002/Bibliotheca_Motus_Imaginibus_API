using System.Text.Json.Serialization;

namespace Bibliotheca_Motus_Imaginibus_API.Entities
{
    public class Ratings
    {
        public int Id { get; set; }
        public decimal RatingNumber { get; set; } 
        public int MovieId { get; set; }
        public string UserId { get; set; }
        public string Comment { get; set; }

        [JsonIgnore]
        public User User { get; set; }

        [JsonIgnore]
        public Movie Movie { get; set; }
    }
}
