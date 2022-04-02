using System.ComponentModel.DataAnnotations;

namespace SanaHomeWork1.Models
{
    public class User
    {
        [Required(ErrorMessage = "Будьласка введіть ваше ім'я!")]
        public string Name { get; set; }
    }
}
