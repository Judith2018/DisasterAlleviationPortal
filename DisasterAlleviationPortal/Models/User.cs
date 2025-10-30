using System.ComponentModel.DataAnnotations;

namespace DisasterAlleviationPortal.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }
    }

}
