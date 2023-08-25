using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCWebApplication1.Models;

namespace MVCWebApplication1.Data
{
    public class MVCWebApplication1Context : DbContext
    {
        public MVCWebApplication1Context (DbContextOptions<MVCWebApplication1Context> options)
            : base(options)
        {
        }

        public DbSet<MVCWebApplication1.Models.UserModel> UserModel { get; set; } = default!;
    }
}
