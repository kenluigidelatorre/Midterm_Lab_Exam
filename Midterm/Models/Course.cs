namespace Midterm.Models
{
    public class Course
    {
        public Guid CourseId { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public int Units { get; set; }
    }
}
