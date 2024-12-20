namespace WebApi.Models
{
    public class User
    {
        public int Id { get; set; } // Primary Key
        public required string Username { get; set; }
        public required string Password { get; set; } // Hashed password
        public required string Role { get; set; } // Admin, User, etc.
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();
        public ICollection<PrintJob> PrintJobs { get; set; } = new List<PrintJob>();
    }
}
