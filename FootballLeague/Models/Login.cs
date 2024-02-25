using System.ComponentModel.DataAnnotations;

namespace FootballLeague.Models
{
    public class Login
    {
        [Required(ErrorMessage="Nazwa jest wymagana")]
        public string? Username { get; set; }

        [Required(ErrorMessage="Hasło jest wymagane")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
