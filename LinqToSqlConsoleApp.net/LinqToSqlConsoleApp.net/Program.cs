using System.Linq;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSqlConsoleApp.net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataClasses1DataContext obj = new DataClasses1DataContext();
            
            //INsertion
            student s1= new student();
            s1.name = "Jayanth";
            s1.email = "cjy@gmail.com";
            s1.join_date = DateTime.Now;
            obj.students.InsertOnSubmit(s1);
            obj.SubmitChanges();

            s1.email = "asd";
            obj.SubmitChanges();
            
            //Selection
            List<student> data=obj.students.ToList();
            for(int i=0;i<data.Count; i++)
            {
                Console.WriteLine(data[i].name.ToString());

            } 

            obj.students.Delete

            
        }
    }
}
