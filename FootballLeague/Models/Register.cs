using System.ComponentModel.DataAnnotations;

namespace FootballLeague.Models
{
    public class Register
    {
        [Required(ErrorMessage = "Nazwa jest wymagana")]
        [MinLength(3, ErrorMessage = "Nazwa musi mieć co najmniej 3 znaki.")]
        [MaxLength(50, ErrorMessage = "Nazwa musi mieć maksymalnie 50 znaków.")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Email jest wymagany")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Hasło jest wymagane")]
        [DataType(DataType.Password)]
        [MinLength(5, ErrorMessage = "Hasło musi mieć co najmniej 5 znaków.")]
        [MaxLength(20, ErrorMessage = "Hasło musi mieć maksymalnie 20 znaków.")]
        public string? Password { get; set; }

    }
}
