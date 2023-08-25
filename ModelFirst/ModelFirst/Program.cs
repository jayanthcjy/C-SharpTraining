using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServerModelContainer container = new ServerModelContainer();

            //Insertion of data
            //School school = new School()
            //{
            //    Id = 2,
            //    Name = "Viram"
            //};
            //container.Schools.Add(school);
            //container.SaveChanges();

            //selection of data
            //vat data=container.Schools.ToList();

            //Selection of Data using where
            //var data = container.Schools.Where(p => p.Name == "Viram");

            //updating the data
            //var data = container.Schools.FirstOrDefault(p => p.Id == 2);
            //if (data != null)
            //{
            //    data.Name = "Vikram";
            //    container.SaveChanges();
            //}

            //removing the data
            //var data = container.Schools.FirstOrDefault(p => p.Id == 2);
            //if (data != null)
            //{
            //    container.Schools.Remove(data);
            //    container.SaveChanges();
            //}






        }
    }
}
