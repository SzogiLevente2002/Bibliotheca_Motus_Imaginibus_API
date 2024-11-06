using System.ComponentModel.DataAnnotations;

namespace Bibliotheca_Motus_Imaginibus_API.DTOs
{
    public class LoginDTO
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }
    }
}
