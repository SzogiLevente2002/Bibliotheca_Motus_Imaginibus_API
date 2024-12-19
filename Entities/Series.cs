namespace Bibliotheca_Motus_Imaginibus_API.Entities
{
    public class Series
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public DateTime ReleasedDate { get; set; }
        public DateTime AddedAt { get; set; }
        public int Length { get; set; }
        public int NumberOfSeasons { get; set; }
        public int NumberOfEpisodes { get; set; }

        public string Actor1 { get; set; }

        public string Actor2 { get; set; }

        public string Actor3 { get; set; }

    }
}
