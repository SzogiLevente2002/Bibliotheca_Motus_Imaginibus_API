using System.ComponentModel.DataAnnotations;

namespace Bibliotheca_Motus_Imaginibus_API.DTOs
{
    public class RegisterDTO
    {
        

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }
    }
}
