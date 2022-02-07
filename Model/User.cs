using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Model
{
    public class User
    {
        public int ID { get; set; }
        [Required]
        public string? Username { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? BirthdayDate { get; set; }
    }
}
