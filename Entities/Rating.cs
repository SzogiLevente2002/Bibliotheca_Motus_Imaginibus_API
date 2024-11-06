namespace Bibliotheca_Motus_Imaginibus_API.Entities
{
    public class Rating
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public int RatingNumber { get; set; }

        public string Comment { get; set; }

        public User User { get; set; }
    }
}
