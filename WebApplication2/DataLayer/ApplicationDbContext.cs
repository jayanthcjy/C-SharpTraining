
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace DataLayer
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base()
        {

        }

        public DbSet<PersonDetails> PersonDetailss { get; set; }
        
    }
}
