// C# program to illustrate
// the use of 'as' operator
using System;
using System.Text;
using System.Collections.Generic;

class GFG
{

    // Main Method
    public static void Main()
    { 
            
        Dog dog = new Dog();
        Animal animal = dog as Animal;
        // Console.WriteLine(dog.GetType() +" "+animal.GetType());
        //Console.WriteLine(animal.Hi()+" "+dog.Hi());

        int? a = null;
        int? c = null;
        int ? d = 12;
        int b = a ?? c ?? -1;
        if(a==c) {
            Console.WriteLine(a.GetValueOrDefault());  // output: -1
        }

        string s = "          ";

        Console.WriteLine(string.IsNullOrEmpty(s));
        Console.WriteLine(string.IsNullOrWhiteSpace(s));

        List<string> names = new List<string>();
        string firstName = names.FirstOrDefault(); // Returns null
        string lastName = names.LastOrDefault(); // Returns null

        Console.WriteLine($"{firstName} {lastName}");

    }
    class Animal {
        public void Hi()
        {
            Console.WriteLine("HI");
        }
    }
    class Dog : Animal {
        public void Hello()
        {
            Console.WriteLine("Hello");
        }
    }
}

