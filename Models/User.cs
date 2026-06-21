namespace JobApplication.Models
{
    public class User
    {
            public Guid Id { get; set; }
            public string Email { get; set; }
            public string FullName { get; set; }
            public string PasswordHash { get; set; }
            public string PhoneNumber { get; set; }
            public DateTime CreatedAt { get; set; }
            public bool IsActive { get; set; }

            // Navigation
            public ICollection<JobApplication> Applications { get; set; }
            public Resume Resume { get; set; }
        
    }
}
