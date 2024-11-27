namespace Bibliotheca_Motus_Imaginibus_API.DTOs
{
    public class RatingsDTO
    {
       
        public int MovieId { get; set; }
        public decimal RatingNumber { get; set; }
        public string UserId { get; set; }
        public string Comment { get; set; }
    }

}
