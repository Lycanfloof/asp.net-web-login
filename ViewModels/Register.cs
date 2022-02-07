using System.ComponentModel.DataAnnotations;

namespace MyWebApp.ViewModels
{
    public class Register
    {
        [Required]
        [DataType(DataType.Text)]
        public string? Username { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Fill the password confirmation field")]
        public string? ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string? FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string? LastName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string? Name { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public string? Birthdate { get; set; }
    }
}
