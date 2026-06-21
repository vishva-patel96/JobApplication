namespace JobApplication.Models
{
    public class JobApplication
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid JobId { get; set; }
        public ApplicationStatus Status { get; set; } // Pending, Under Review, Rejected, Offered
        public DateTime AppliedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        // Navigation
        public User User { get; set; }
        public Job Job { get; set; }
    }
}
