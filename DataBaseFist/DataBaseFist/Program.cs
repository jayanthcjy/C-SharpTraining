using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JayanthEntities db = new JayanthEntities();

            //Isertion of data
            //Posts1 posts1 = new Posts1()
            //{
            //    Id = 1,
            //    DatePublished = DateTime.Now,
            //    Title = "Title1",
            //    Body = "Test on 11"              

            //};
            //db.Posts1.Add(posts1);
            //db.SaveChanges();


            //Selection of data
            //List<Posts1> data=db.Posts1.ToList();

            //selection of specific data using the where condition
            //var posts = db.Posts1.Where(p=>p.Id==2);
            //foreach(Posts1 post in data) {
            //    Console.WriteLine(post.Body);
            //}

            //update data fo the table from database
            //var data = db.Posts1.FirstOrDefault(p => p.Id == 1);
            //if (data != null)
            //{
            //    data.Title = "Test1";
            //    db.SaveChanges();
            //}

            //remove data fo the table from database
            //var data = db.Posts1.FirstOrDefault(p => p.Id == 1);
            //if (data != null)
            //{
            //    db.Posts.Remove(data);
            //    db.SaveChanges();
            //}

        }
    }
}
