using System.Data.Entity;
using DemoApplication.Models;

namespace DemoApplication.Data
{
    public class UserContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
    }
}
