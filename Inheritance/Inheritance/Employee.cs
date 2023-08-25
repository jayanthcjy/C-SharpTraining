using System;

// Base class
public class Employee
{
    public string Name;
    public int Age;
    public string Department;
    public int a = 10;

     public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Department: {Department}");
    }
}

// Derived class
 public class Manager : Employee
{
    public int TeamSize;
    public override void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Department: {Department}, TeamSize: {TeamSize}");
    }
    public  void OrganizeMeeting()
    {
       
        Console.WriteLine($"Manager {Name} is organizing a meeting.");
    }
}

// Derived class
public class Developer : Employee
{
    public string ProgrammingLanguage;


    
    public void WriteCode()
    {
       
        Console.WriteLine($"Developer {Name} is writing code in {ProgrammingLanguage}.");
    }
}

internal class Inter:Employee
{
    public string Name;
}
 class Classs:Inter
{
    internal static int q = 10;
}


