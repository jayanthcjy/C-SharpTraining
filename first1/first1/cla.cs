using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class cla

{
    private  FileStream filestreaam;
    public static int x = 1000;
    public int a;
    public int b;



    public cla() { }
    //
    //static cla() { }
    public cla(int aa, int bb)
    {
        b = bb;
        a = aa;
        // a=10;
    }
    public static void s()
    {
        Console.WriteLine("Static method");
    }


    ~cla() {
        Console.WriteLine("Destroyed");
    
    }
    
    

public void dis()
{
    Console.WriteLine(a+" "+b);
}
public static void Class2()

{
    Console.WriteLine("Class1");


}
}