using Microsoft.EntityFrameworkCore;
using DisasterAlleviationPortal.Models; 

namespace DisasterAlleviationPortal.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<DisasterReport> DisasterReports { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
