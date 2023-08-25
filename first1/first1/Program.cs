using System;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace first1
{
    public class Program
    {
        //public static int Id=20;
        readonly int ii;
        public String Name;
        public static int i=9;
        bool s=false;
        int z =2147483647;
        //int o=z;
       //private Program(String n) { Name = n; }   
        public static void Main(string[] args)
        {                                             
            //second.Program h1 = new second.Program();
            //h1.sayHi();


            Console.WriteLine(i);
            int[] a = { 1, 2, 3 };

            
            const int c=1 ;
            long b;
            float f = 1.4f;
            double g = 3.44;
            //decimal d = 3.4444D;
            
                       //Console.WriteLine("ID value is"+Id);
            //int k;


           // Console.WriteLine("K value" + k);


            
            b = 1;


            cla c2 = new cla(1,100);
            cla c3 = new cla(2,20);
            Console.WriteLine();
            //cla c4=new cla();
            //int n=cla.x;
           

            cla ob1 = new cla(1,2);
            ob1 = null;
            cla ob2 = new cla(10,20);
            cla a1=new cla();
           // GC.Collect();
            
            a1.dis();
            cla.Class2();

            cla c1 = new cla(1,2);
            Console.WriteLine(c1.a+"ksdjcn");
            //c1.dis();
            //int n=cla.x;
            //c1.s();
            //cla.s();
            //c1.Class2();
            //cla co1 = new cla(c1);
            //co1.dis();
            cla.Class2();
            int k = cla.x ;
            Console.WriteLine("X vaalue is "+k);
            Program1.u = 10;
            /* GC.Collect();
             GC.Collect();
             GC.Collect();

             Console.WriteLine("Called");
             Console.WriteLine("the no fo obj " + GC.CollectionCount(0));
             Console.WriteLine("the no fo obj " + GC.CollectionCount(1));
             Console.WriteLine("the no fo obj " + GC.CollectionCount(2));
             Console.WriteLine(GC.GetGeneration(ob2));
             Console.WriteLine("the no fo obj " + GC.CollectionCount(0));
             Console.WriteLine("the no fo obj " + GC.CollectionCount(1));
             Console.WriteLine("the no fo obj " + GC.CollectionCount(2));*/

            // MyClass oj=new MyClass();
            int h= 0;
            cla id = new cla(10, 20);
            Refer(id);
            Console.WriteLine(id.a +" "+id.b);
           
            using (MyClass ob=new MyClass())

            {

               
                StreamReader reader = new StreamReader(ob.f);
               
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {

                         Console.WriteLine(line);

                    }
               // ob.Hi();
                //throw new Exception("hi");
                

                    //ob.Dispose();
                Console.WriteLine("Inside dispose");
                //if (b < 5)
                //{
                //    throw new Exception("b is less than 5");
                //}

            }
           

            Program1 p1 = new Program1(1,2);
            //p1.sayHi();
            Console.WriteLine("Hello");
            //Console.WriteLine(Program1.x=10);
            //Console.WriteLine(Program1.u);
            Console.WriteLine(Program1.sayHi());
            Hello(1, 2, 3, 4,5,6,7);
        }


        public static void Hello(int a, int b, params int[] numbers)
        {
            numbers.Append(10);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

        }
        public static  void Refer(cla idd)
        {
            idd.a = 40;
        }

    }


    public class Program1
    {
        public static int u=1000;

        int a;
        int b;
        int c;

        public  Program1(int aa, int bb){

            this.a = aa; this.b = bb;

            }
        static Program1()
        {
            Console.WriteLine("Program1");
        }

        public static int sayHi()
        {

            Console.WriteLine("Hi");
            Console.WriteLine("The x value is "+u);
            return 0;
        }
    }
}
