//using System;
//using System.Globalization;
//using System.IO;

//class MyClass : IDisposable
//{
//    private bool disposed = false;
//    public const int a = 10;
//    public readonly int b = 20;

//    public MyClass() {
//    }
//    public MyClass(int b) { this.b = b; }
//    public FileStream filestream=new FileStream("C:\\Users\\Jayanth C\\Documents\\C#Tutorial",FileMode.Open,FileAccess.Read);

//    // Dispose method
//    public void Dispose()
//    {
//        Dispose(true);
//        GC.SuppressFinalize(this);
//    }

//    // Dispose implementation
//    protected virtual void Dispose(bool disposing)
//    {
//        if (!disposed)
//        {
//            if (disposing)
//            {
//                // Dispose managed resources here
//                Console.WriteLine("Disposing managed resources.");
//            }

//            filestream.Close();
//            // Dispose unmanaged resources here
//            Console.WriteLine("Disposing unmanaged resources.");

//            disposed = true;
//        }
//    }

//    // Finalizer (destructor)
//    ~MyClass()
//    {
//        Dispose(false);
//    }
//}

//class Program
//{

//    static void Main()
//    {
//        byte a = 1;
//        int aa=20;

//        int c=MyClass.a;
//        MyClass q = new MyClass(1);
//        Int32 z = 12;


//        const int b = 2;
//       // const MyClass ob = new();
//        using (MyClass obj = new MyClass())
//        {
//            // Perform operations with obj
//            Console.WriteLine("Using MyClass instance.");
//        }

//        Program p=new Program();
//        p.Hi(b);

//        Console.WriteLine("Program completed.");
//    }
//    public void Hi(  int a)
//    {

//    }
//}

//using System;
//namespace ExtensionMethods
//{
//    public class OldClass
//    {
//        public int x = 100;
//        public void Test1(int a,int b)
//        {
//            Console.WriteLine("Method one: " + this.x);
//        }

//        public void Test2()
//        {
//            Console.WriteLine("Method two: " + this.x);
//        }
//    }

//    public static class NewClass
//    {
//        public static void Test3(this OldClass O)
//        {
//            Console.WriteLine("Method Three");
//        }
//        public static void Test4(this OldClass O, int x)
//        {
//            Console.WriteLine("Method Four: " + x);
//        }
//        public static void Test5(this OldClass O)
//        {
//            Console.WriteLine("Method Five:" + O.x);
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            OldClass ob= new OldClass();
//            ob.Test4(ob.x);
//        }
//    }
//}

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
namespace ConcurrentCollections
{
    class Program
    {
        static Dictionary<int, string> dictionary = new Dictionary<int, string>();

        static void Main(string[] args)
        {
            Thread t1 = new Thread(Method1);
            Thread t2 = new Thread(Method2);
            t1.Start();
            t2.Start();



            Animal animal = new Dog();
            Dog dog = (Dog)animal; // Downcasting from Animal to Dog
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            var anime = new Animal();
            Console.WriteLine(anime.GetType());
            Console.WriteLine();

            Console.ReadKey();
        }

        public static void Method1()
        {
            for (int i = 0; i < 10; i++)
            {
                dictionary.TryAdd(i, "Added By Method1 " + i);
                Thread.Sleep(100);
            }
        }
        class Animal { }
        class Dog : Animal { }



        public static void Method2()
        {

            ConcurrentStack<int> s1 = new ConcurrentStack<int>();
            s1.Push(1);
            for (int i = 0; i < 10; i++)
            {
                dictionary.TryAdd(i, "Added By Method2 " + i);
                Thread.Sleep(100);
            }
        }
        public abstract class A
        {
            //public abstract int Value { get; }
            public abstract int Hh(int a);
            public int a = 10;
        }
        public class B:A

        {
            
            public override int Hh(int aa)
            {
                B b=new B();
                b.Hh(aa);
                int x=b.a;
                
                
                throw new NotImplementedException();
            }

        }
    }
}
