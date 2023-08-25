using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;


namespace CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)

        {
            BlogDbContext db = new BlogDbContext();

            //Insertion of data using xml file
            XDocument xmlData = XDocument.Load("C:\\Users\\Jayanth C\\Documents\\products.xml");
            var elements = xmlData.Descendants("Product")
                                .Select(e => new Post
                                {
                                    Title = e.Element("Title").Value,
                                    Body = e.Element("Body").Value,
                                    DatePublished=DateTime.Now

                                }).ToList();
            //foreach (var element in elements)
            //{
            //    Post post = new Post();
            //    post.Title = element.ElementTitle.ToString();
            //    post.Body = element.ElementBody.ToString();
            //    post.DatePublished = DateTime.Now;

            //    db.Posts.Add(post);
            //    db.SaveChanges();

            //}
            db.Posts.AddRange(elements);
            db.SaveChanges();



            //Insertion of data
            //Post post1 = new Post()
            //{
            //    Id = 100,
            //    DatePublished = DateTime.Now,
            //    Title = "Test1000",
            //    Body = "Test on Friday"
            //};
            //db.Posts.Add(post1);
            //db.SaveChanges();


            //creting a store procedure in the database
            //using (var context = new BlogDbContext())
            //{
            //    // SQL command to create the stored procedure
            //    string createStoredProcedureSql = @"
            //    CREATE PROCEDURE GetProductsByCategory
            //        @Category int
            //    AS
            //    BEGIN
            //        SELECT *
            //        FROM Posts
            //        WHERE Title = @Category
            //    END
            //";
            //    try
            //    {
            //        // Execute the SQL command to create the stored procedure
            //        context.Database.ExecuteSqlCommand(createStoredProcedureSql);

            //        Console.WriteLine("Stored procedure created successfully.");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"Error creating stored procedure: {ex.Message}");
            //    }
            //}

            //executing the store procedure
            //var datatyp = new SqlParameter("@Category", 3);
            //var data = db.Database.SqlQuery<Post>("exec dbo.GetProductsByCategory @Category", datatyp).ToList();
            //foreach(var item in data)
            //{
            //    Console.WriteLine($"{item.Id}"); 
            //}

            //selection of the table from database
            //List<Post> data = db.Posts.ToList();
            //foreach (Post post in data)
            //{
            //    Console.WriteLine(post.Title);
            //}


            //Getting only the single row
            //var data = db.Posts.FirstOrDefault(e => e.Body == "Test on Friday");

            //update data fo the table from database
            //var data = db.Posts.FirstOrDefault(p => p.Id == 1);
            //if (data != null)
            //{
            //    data.Title = "Test1";
            //    db.SaveChanges();
            //}


            //remove data fo the table from database
            //var data = db.Posts.FirstOrDefault(p => p.Id == 1);
            //if (data != null)
            //{
            //    db.Posts.Remove(data);
            //    db.SaveChanges();
            //}

        }
    }
}
