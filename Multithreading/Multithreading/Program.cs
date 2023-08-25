using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;

public class Program
{
    public static void Main(string[] args)
    {       

       
        int a = 10, b = 20;
        //Creating thread
        Thread thread = new Thread(() => Add(a, out b));
        //Strating thread
        thread.Start();
        Console.WriteLine("b value before assigning in Add method : " + b);
        Thread.Sleep(2000);
        Console.WriteLine("b value after assigning in Add method: " + b);
        thread.Join();

    }

    public static void Add(in int aa, out int bb)
    {
        Console.WriteLine("Addition Thread");
        Thread.Sleep(1000);

        bb = 200;
        Thread.Sleep(1000);

    }
}

   
