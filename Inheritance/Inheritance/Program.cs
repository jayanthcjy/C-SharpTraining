using System;


namespace Inheritance
{
    //Main Class
    public class Program
    {
        public static void Main(string[] args)
        {
            Manager manager = new Manager()
            {
                Name = "John Doe",
                Age = 35,
                Department = "Engineering",
                TeamSize = 10
            };

            manager.DisplayInfo();
            manager.OrganizeMeeting();

            Employee employee = new Inter();

            Part p1= new Part(10,20);
            p1.m1();


            //Developer developer = new Developer()
            //{
            //    name = "jane smith",
            //    age = 28,
            //    department = "development",
            //    programminglanguage = "c#"
            //};

            //developer.DisplayInfo();
            //developer.WriteCode();
            //Class1 c1= new Class2();
            Employee emp = new Manager()
            {
                Name = "as",
                Age = 23,
                Department="sd",
                TeamSize = 10

            };
            emp.DisplayInfo();

            Abs ad= new AbsClass();
            ad.method2();

            IInter k = new c2();
            k.Hi();
            ClassA obj=new ClassC();
            //obj.res();
            obj.Method(9);
            var a = 10;
            int c = 20;
            var b=30;
            
            Abc n = new Abc();
            n.Add(a, b,c);
            n.Add(a, b, c);
            Console.WriteLine("asd");
            ClassA ob = new ClassC();
            ob.Method(9);
            Math.Abs(10);

        }
    }

}
