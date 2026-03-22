namespace Midterm.Models
{
    public class Section
    {
        public Guid SectionId { get; set; }
        public string SectionCode { get; set; } = string.Empty;
        public Guid CourseId { get; set; }
        public Guid InstructorId { get; set; }
        public string Room { get; set; } = string.Empty;
        public DateTime Schedule { get; set; }
    }
}
