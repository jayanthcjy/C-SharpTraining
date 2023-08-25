using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCWebApplication5.Models;

namespace MVCWebApplication5.Data
{
    public class MVCWebApplication5Context : DbContext
    {
        public MVCWebApplication5Context (DbContextOptions<MVCWebApplication5Context> options)
            : base(options)
        {
        }

        public DbSet<MVCWebApplication5.Models.User> User { get; set; } = default!;
    }
}
