using System.Text.Json.Serialization;

namespace Bibliotheca_Motus_Imaginibus_API.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Director { get; set; }

        public DateTime ReleasedDate { get; set; }
        public string Genre { get; set; }
        public int Length { get; set; }

        [JsonIgnore]
        public byte[]? Poster { get; set; }

        [JsonIgnore]
        public ICollection<Ratings>? Ratings { get; set; }
    }
}
