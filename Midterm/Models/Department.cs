namespace Midterm.Models
{
    public class Department
    {
        public Guid DepartmentId { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Office { get; set; } = string.Empty;
    }
}
