using System;
using System.Xml.Serialization;

namespace DelegatesExample
{
    public delegate void CallbackMethodHandler(string message);
    public delegate void ReturnMethod(string message);
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();            
           
            DoSomework("Hi",obj.CallbackMethod);

            Console.ReadKey();
        }

        public static void DoSomework(string message,CallbackMethodHandler del)
        {
            Console.WriteLine("Processing some Task");
            del("Pranaya");
        }

        public void CallbackMethod(string message)
        {
             Console.WriteLine($"Hello: {message}, Good Morning");
            inter(DoSomework);
            EventHandler
             
        }

        public static void inter(CallbackMethodHandler dell)
        {

        }
       
    }
   
}