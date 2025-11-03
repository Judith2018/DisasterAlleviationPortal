using System.ComponentModel.DataAnnotations;

namespace DisasterAlleviationPortal.Models
{
    public class Volunteer
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Availability { get; set; }
        public DateTime DateSubmitted { get; set; } = DateTime.Now; // Auto-filled when saved

        [Required]
        public DateTime? PreferredDate { get; set; } // Optional date chosen by volunteer

    }

}
