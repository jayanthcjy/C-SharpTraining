using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCWebApplication4.Models;

namespace MVCWebApplication4.Data
{
    public class MVCWebApplication4Context : DbContext
    {
        public MVCWebApplication4Context (DbContextOptions<MVCWebApplication4Context> options)
            : base(options)
        {
        }

        public DbSet<MVCWebApplication4.Models.Movie> Movie { get; set; } = default!;
    }
}
