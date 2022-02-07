using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Model
{
    public class User
    {
        public int ID { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime? BirthdayDate { get; set; }
    }
}
