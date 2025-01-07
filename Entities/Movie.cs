using Bibliotheca_Motus_Imaginibus_API.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public string Director { get; set; }
    public string Description { get; set; }

    public string Actor1 { get; set; }
    public string Actor2 { get; set; }
    public string Actor3 { get; set; }

    public DateTime ReleasedDate { get; set; }
    public DateTime AddedAt { get; set; }
    public int Length { get; set; }

    [JsonIgnore]
    // Navigational property for Ratings
    public ICollection<Ratings> Ratings { get; set; } = new List<Ratings>();

    [JsonIgnore]
    // Poster as byte array (binary data storage)
    public byte[]? Poster { get; set; } // Poster stored as a byte array

    // Új mezők a sorozatok kezeléséhez
    public bool IsSeries { get; set; } = false; // Alapértelmezett: nem sorozat
    public int? NumberOfSeasons { get; set; } // Évadok száma (null lehet, ha nem sorozat)
    public int? NumberOfEpisodes { get; set; } // Epizódok száma (null lehet, ha nem sorozat)
}
