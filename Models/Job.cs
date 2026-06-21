namespace JobApplication.Models
{
    public class Job
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<JobApplication> Applications { get; set; }
    }
    public enum ApplicationStatus
    {
        Pending = 0,
        UnderReview = 1,
        Rejected = 2,
        Offered = 3,
        Accepted = 4
    }
}
