using Microsoft.EntityFrameworkCore;
namespace DataLayer

{

    
    public class PersonDetails
    {

        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Mail { get; set; }
    }
}