namespace DreamJob.entities
{
    public class Job
    {
        public DateTime CreatedAt { get; set; }
        public string Position { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string SalaryRange { get; set; }
        public string Place { get; set; }
    }
}