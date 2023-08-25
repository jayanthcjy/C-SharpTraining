using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class Post
    {
        public int Id { get; set; }
        public DateTime DatePublished { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        // New property to be added
        public string Email { get; set; }

        public string Location { get; set; }

        public char Gender { get;set; }
    }
}
