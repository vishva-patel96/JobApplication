namespace JobApplication.Models
{
    public class Resume
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string BlobUrl { get; set; }
        public string FileName { get; set; }
        public DateTime UploadedAt { get; set; }

        public User User { get; set; }
    }
}
