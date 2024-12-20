namespace WebApi.Models
{
    public class PrintJob
    {
        public int Id { get; set; } // Primary Key
        public string LabelName { get; set; } // Name of the label
        public string Status { get; set; } = "Pending"; // Default: Pending
        public string PrinterDetails { get; set; } // Printer-specific information
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Timestamp
        public DateTime? PrintedAt { get; set; } // Completion timestamp

        // Relationships
        public int UserId { get; set; } // FK to User
        public User User { get; set; } // Navigation property
        public int LocationId { get; set; } // FK to Location
        public Location Location { get; set; } // Navigation property
    }
}
