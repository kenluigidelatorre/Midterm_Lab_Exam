namespace Midterm.Models
{
    public class Enrollment
    {
        public Guid EnrollmentId { get; set; }
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
        public string Semester { get; set; } = string.Empty;
        public decimal Grade { get; set; } 
    }
}
