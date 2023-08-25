using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class BlogDbContext:DbContext
    {
        public BlogDbContext()
            : base("BlogDbContext")
        {
            Database.SetInitializer<BlogDbContext>(new CreateDatabaseIfNotExists<BlogDbContext>());
        }
        public DbSet<Post> Posts { get; set; }

    }
}
