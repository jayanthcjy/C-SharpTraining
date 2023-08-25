namespace DemoApplication.Models
{
    public class Student
    {
        public string? RequestId { get; set; }
        public string Name;
        public int Age;
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}