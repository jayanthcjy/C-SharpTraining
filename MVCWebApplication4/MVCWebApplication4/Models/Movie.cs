using System.ComponentModel.DataAnnotations;

namespace MVCWebApplication4.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
