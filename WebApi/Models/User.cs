namespace WebApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; } // In a real application, store hashed passwords
        public required string Role { get; set; } // Add Role property
    }
}