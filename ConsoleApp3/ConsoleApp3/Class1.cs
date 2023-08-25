using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    public class In1
    {
        public virtual void m1()
        {
            Console.WriteLine("m1");
        }
    }
    public class In2:In1
    {
        public override void m1()
        {
            Console.WriteLine("override m1");
        }
    }


    public class Class1
    {

    }
     public class Class2
    {
        public void method1()
        {
            Console.WriteLine("sealed method1");
        }
    }

    public static class Class3
    {
         public static void method2(this Class2 ob)
        {
            Console.WriteLine("extended method2");
        }
    }
}
