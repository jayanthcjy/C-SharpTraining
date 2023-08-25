using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class A
    {
        public int a;
        //public int b = 10;
        //public static int c = 20;
        public static int d=10;

        public A(int a) {
            d = a;
        }

    }
    public class B
    {
        public static void Main() { 
        
            A a = new A(20);
        }   
    }
}
