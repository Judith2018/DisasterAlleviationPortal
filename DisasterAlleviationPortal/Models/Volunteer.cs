namespace DisasterAlleviationPortal.Models
{
    public class Volunteer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ContactNumber { get; set; }
        public string Availability { get; set; }
        public DateTime DateSubmitted { get; set; } = DateTime.Now; // Auto-filled when saved
        public DateTime? PreferredDate { get; set; } // Optional date chosen by volunteer

    }

}
