using Microsoft.AspNetCore.Identity;

namespace Bibliotheca_Motus_Imaginibus_API.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Watchlist> Watchlists { get; set; }

        public ICollection<Ratings> Ratings { get; set; }
    }
}
