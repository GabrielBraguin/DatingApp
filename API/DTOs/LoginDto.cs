using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class LoginDto
    {
        [Required]
        [MaxLength(20)]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}