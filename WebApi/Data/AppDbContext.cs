using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<PrintJob> PrintJobs { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<LabelTemplate> LabelTemplates { get; set; }
    }
}