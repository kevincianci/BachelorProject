namespace WebApi.Models
{
    public class AuditLog
    {
        public int Id { get; set; } // Primary Key
        public string Action { get; set; } // Action performed (e.g., Login, Upload)
        public string Details { get; set; } // Additional details
        public DateTime Timestamp { get; set; } = DateTime.UtcNow; // Action timestamp
        public int UserId { get; set; } // Foreign Key to User
        public User User { get; set; } // Navigation property
    }
}