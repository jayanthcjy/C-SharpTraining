using System;

class ClassA
{
  public virtual void Method(int a)
    {
        Console.WriteLine("ClassA");
    }
}
class ClassB:ClassA
{
    public new void Method(int a)
    {
        Console.WriteLine("ClassB");
    }
   

}
class ClassC : ClassB
{
    public  void Method(int a)
    {
        Console.WriteLine("ClassB");
    }

}
    


sealed class Class1 
{
    
}
public abstract class Abs
{
     public  void method1(){    }
    abstract public void method2();
}
public class AbsClass:Abs
{
    public override void method2()
    {
        Console.WriteLine("AbsClass Method2");
    }
}
partial  class Part
{
    public int i;
    public void m1()
    {
        Console.WriteLine($"The sum is {i + j}");
    }

}
partial class Part
{
    public int j;
    //public int i;
    public Part(int ii, int jj)
    {
        this.i = ii;
        this.j = jj;
    }
       

}
public interface IInter
{
    void Hi();
}
public interface IInter1
{
    void Hi();

}
public class Chsj : IInter,IInter1
{
     public void Hi() {
        Console.WriteLine("hi method from interface");

    }
}

public class c2 : IInter 
{
    public void Hi()
    {
        Console.WriteLine("second class");
        State.method();
    }
}

static class State
{
    public static void method()
    {
        
    }
}

public class Abc
{
    public void Add(  int b,int c, params int[] a)
    {
        Console.WriteLine("a");
    }
    public void Add( int b, params int[] a)
    {

        Console.WriteLine(b);
    }
}


