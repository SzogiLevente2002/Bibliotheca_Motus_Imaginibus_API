namespace Bibliotheca_Motus_Imaginibus_API.DTOs
{
    public class WatchlistDTO
    {
        // A felhasználó ID-ja, aki hozzáadta a filmet a watchlist-jéhez
        public string UserId { get; set; }

        // A film ID-ja, amelyet hozzáadnak a watchlisthez
        public int MovieId { get; set; }

        // Az időpont, amikor a filmet hozzáadták (opcionális, ha nem küldöd el, a szerver automatikusan beállítja)
        public DateTime? AddedDate { get; set; } = DateTime.Now;  // alapértelmezett érték: most
    }

}
