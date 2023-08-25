
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Collections.Specialized;

//public class Program
//{
//    public static void Main()
//    {

//        Object[] a = new Object[2] { 1, 2 };
//        Object[] newArray = new Object[a.Length];
//        a.CopyTo(newArray,0);

//        Object[] newArray1 = (Object[])a.Clone();
//        a[1] = 3;
//        foreach(Object i in newArray1)
//        {
//            Console.WriteLine(i);
//        }
//        a.Last();
//        string s = Console.ReadLine();
//        var a1= 123;
//        // a = "asd";
//        Console.WriteLine(a);
//        //dynamic n=12;
//        //n = "123";
//        //Console.WriteLine(n);
//        dynamic q = "arrff";
//        Console.WriteLine(q.Length);
//        int[] ar = new int[4];
//        Array.Sort(ar);
//        List<int> list = new List<int>();
//        Dictionary<int, string> dic = new Dictionary<int, string>();
//        dic.Add(1, "23");
//        //int aa=dic[3];
//        Array.Resize(ref ar, 7);
//        Console.WriteLine("ar" + ar[6]);

//        Console.WriteLine(dic.ElementAt(0).Key);
//        Console.WriteLine(dic);
//        Console.WriteLine(dic.ContainsValue("23"));
//        foreach (string value in dic.Values)
//        {
//            Console.WriteLine(value);
//        }

//        Queue<int> qu = new Queue<int>();
//        qu.Enqueue(1);
//        LinkedList<int> l = new LinkedList<int>();
//        l.AddLast(1);
//        l.AddFirst(2);
//        l.FindLast(2);



//        ObservableCollection<int> ints = new ObservableCollection<int>();
//        ints.Add(1);
//        ints.Add(2);
//        ints.Add(3);
//        foreach (int i in ints)
//        {
//            Console.WriteLine(i);
//        }
//        Console.WriteLine(ints);
//        //INotifyCollectionChanged
//        ConcurrentQueue<int> ints1 = new ConcurrentQueue<int>();
//        ConcurrentBag<int> ba = new ConcurrentBag<int>();
//        ba.Add(10);
//        ba.Add(2);
//        ba.Add(1);
//        ba.TryTake(out a1);
//        ba.Reverse();
//        Console.WriteLine("as" + a);
//        foreach (int i in ba)
//        {
//            Console.WriteLine(i);
//        }
//        HashSet<int> set= new HashSet<int>();
//        set.Add(10);
//        set.Add(2);
//        set.Add(1);
//        set.Add(3);

//        HashSet <int> set2= new HashSet<int>();
//        set.UnionWith(set2);
//        Console.WriteLine("set2");
//        foreach(int i in set2)
//        {
//            Console.Write(i);
//        }
//        Console.WriteLine("set2Over");




//    }
//    public class ClassA: ObservableCollection<int>
//    {

//    }
//}

//using System.Collections;
//using System.Collections.ObjectModel;
//using System.Collections.Specialized;
//using System.Diagnostics;
//class ClassA
//{
//    static void Main(string[] args)
//    {
//        ObservableCollection<string> names = new ObservableCollection<string>();
//        Hashtable ar = new Hashtable();
//        Dictionary<int, string> dic = new Dictionary<int, string>();
//        dynamic a = 10;
//        object aa = 10;
//        aa = "dssd";

//        Console.WriteLine("object" + aa);


//        names.CollectionChanged += names_CollectionChanged;

//        names.Add("Adam");

//        names.Add("Eve");

//        names.Remove("Adam");

//        names.Add("John");

//        names.Add("Peter");

//        names.Clear();


//        static void names_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)

//        {

//            Console.WriteLine("Change type: " + e.Action);
//            Console.ReadLine();
//            if (e.NewItems != null)

//            {

//                Console.WriteLine("Items added: ");

//                foreach (var item in e.NewItems)

//                {

//                    Console.WriteLine(item);

//                }

//            }

//            if (e.OldItems != null)

//            {


//                Console.WriteLine("Items removed: ");

//                foreach (var item in e.OldItems)

//                {

//                    Console.WriteLine(item);

//                }

//            }

//        }
//    }

//}

////using System;
////using System.Collections.Generic;
////using System.Linq;

////public class Program
////{
////    public static void Main()
////    {
////        // Create a list of persons
////        List<Person> persons = new List<Person>
////        {
////            new Person { Name = "John", Age = 25 },
////            new Person { Name = "Alice", Age = 30 },
////            new Person { Name = "Bob", Age = 35 }
////        };

////        // LINQ query to filter and project the persons
////        var result = persons
////            .Where(p => p.Age > 25) // Filter persons older than 25
////            .OrderBy(p => p.Name)  // Sort persons by name
////            .Select(p => p.Name);  // Project only the names
////        dynamic s = 2;
////        object q = 2;

////        // Print the result
////        foreach (var name in result)
////        {
////            Console.WriteLine(name);
////        }
////    }
////}

////    public class Person
////    {
////        public string Name { get; set; }
////        public int Age { get; set; }
////    }
///


////class Program
////{
////    static void Main(string[] args)
////    {
////        int a = 10;
////        int? b = 20;
////        int? c = null;
////        int? d = null;
////        int? e = 30;
////        //string d = null;
////        Hashtable s = new Hashtable();
////        s.Add(2, "a");
////        s.Add("as", "b");


////        SortedDictionary<int, string> sl = new SortedDictionary<int, string>();
////        sl.Add(2, "c");
////        sl.Add(1, "ad");
////        //Console.WriteLine("dic"+sl[0]);
////        KeyValuePair<int, string>[] ak=new KeyValuePair<int, string>[2];
////        //ak.Append(1,"a");

////        SortedList<int, string> sd = new SortedList<int, string>();
////        sd.Add(1, "a");
////        sd.Add(2, "b");
////        sd.Add(3, "c");
////        Console.WriteLine("list"+ sd.GetKeyAtIndex(0));


////        foreach(var i in s.Keys)
////        {
////            Console.WriteLine(i +" "+ s[i]);
////        }



////    }
////}
////public class ClassA 
////{
////    int a;
////    int b;

////}


//using System;
//using System.Collections.ObjectModel;
//using System.ComponentModel;

//public class Person : INotifyPropertyChanged
//{
//    private string name;
//    private int age;

//    public string Name
//    {
//        get { return name; }
//        set
//        {
//            if (name != value)
//            {
//                name = value;
//                OnPropertyChanged(nameof(Name));
//            }
//        }
//    }

//    public int Age
//    {
//        get { return age; }
//        set
//        {
//            if (age != value)
//            {
//                age = value;
//                OnPropertyChanged(nameof(Age));
//            }
//        }
//    }

//    public event PropertyChangedEventHandler PropertyChanged;

//    protected virtual void OnPropertyChanged(string propertyName)
//    {
//        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        // Create an Observable Collection of Person objects
//        ObservableCollection<Person> people = new ObservableCollection<Person>();

//        // Subscribe to the CollectionChanged event
//        people.CollectionChanged += People_CollectionChanged;

//        // Create and add some Person objects to the collection
//        Person person1 = new Person { Name = "John", Age = 30 };
//        Person person2 = new Person { Name = "Jane", Age = 25 };
//        people.Add(person1);
//        people.Add(person2);

//        // Update the properties of a Person object in the collection
//        person1.Name = "John Smith";
//        person2.Age = 28;
//        Dictionary<int, string> d = new Dictionary<int, string>();


//        // Remove a Person object from the collection
//        people.Remove(person2);
//    }

//    private static void People_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
//    {
//        if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
//        {
//            foreach (Person person in e.NewItems)
//            {
//                Console.WriteLine($"Person '{person.Name}' added to the collection.");
//            }
//        }
//        else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
//        {
//            foreach (Person person in e.OldItems)
//            {
//                Console.WriteLine($"Person '{person.Name}' removed from the collection.");
//            }
//        }
//    }
//}


//Investigative questions

///////////////////////////////////////////////////////////////////////////////////////////////////////////////// 
//1) Why do we need explicit type casting
////using System;

////class Animal
////{
////    public string Name { get; set; }
////    public virtual void MakeSound()
////    {
////        Console.WriteLine("The animal makes a sound.");
////    }
////}

////class Dog : Animal
////{
////    public override void MakeSound()
////    {
////        Console.WriteLine("The dog barks.");
////    }
////}



////class Program
////{
////    static void Main()
////    {
////        Animal animal = new Dog();
////        animal.MakeSound();   // Output: The dog barks.

////        Dog dog = (Dog)animal;   // Explicit type casting
////        dog.MakeSound();    // Output: The dog barks.

////       Console.WriteLine(animal.Equals(dog));
////        Console.ReadLine();
////    }
////}




// 3) is and as

//class Program
//{
//    static void Main(string[] args)
//    {
//        //object s = "Hi";
//        //if(s is string)// ildasm //-> isinst     [System.Runtime]System.String
//        //{
//        //    Console.WriteLine(s);
//        //}

//        object obj1 = "Hello";
//        object obj2 = 42;
//        object obj3 = new int[5];


//        string str = obj1 as string;
//        int? num = obj2 as int?;
//        int[] arr = obj3 as int[];

//        Console.WriteLine($"str: {str}");
//        Console.WriteLine($"num: {num}");
//        Console.WriteLine($"arr: {arr}");

//    }
//}

// 4) IEnumerable Interface
////using System;
////using System.Collections;
////using System.Collections.Concurrent;

////public class ClassA : IEnumerable
////{
////    public int a;
////    public int b;
////    public void Add(int aa, int bb)
////    {
////        a = aa;
////        b = bb;
////    }

////    public IEnumerator GetEnumerator()
////    {
////        throw new NotImplementedException();
////    }
////}
////public class Program
////{
////    public static void Main()
////    {       
////        ClassA obj = new ClassA()
////        {
////            { 1,2}
////        };
////        Console.WriteLine(obj.a);
////    }
////}


//Operator overloading

//Cannot overload these &&,||,=,.,?:,->,(),[],

//class MyClass
//{
//    private int value;

//    public MyClass(int value)
//    {
//        this.value = value;
//    }

//    public static MyClass operator +(MyClass left, MyClass right)
//    {
//        left.value += right.value;
//        return left;
//    }

//}

//class Program
//{
//    static void Main()
//    {
//        MyClass a = new MyClass(5);
//        MyClass b = new MyClass(10);

//        MyClass result1 = a += b;

//        Console.WriteLine(result1+" a="+a+"b="+b);  // Output: 15 15 10

//        // a += b;
//        Console.WriteLine(a);       // Output: 15

//        Console.ReadLine();
//    }
//}



//Dictionary

//class Program
//{
//    static void Main(string[] args)
//    {
//        Dictionary<string, int> dic = new Dictionary<string, int>() { };
//        dic.Add("hi", 1);
//        dic.Add("hii", 2);
//        dic.Add("hiii", 3);


//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Xml.Linq;


///Linq quering and dynamic
//class Program
//{
//    static void Main()
//    {
//        // Create a list of dynamic objects
//        List<dynamic> employees = new List<dynamic>
//        {
//            new { Name = "John", Age = 25, Department = "HR" },
//            new { Name = "Jane", Age = 30, Department = "IT" },
//            new { Name = "Alice", Age = 35, Department = "Finance" }
//        };

//        employees.Add(new { Name = "sas", Age = 30,Department="CSE" });
//        // LINQ query using dynamic
//        dynamic query = from emp in employees
//                    where emp.Age > 28 && emp.Department == "IT"
//                    select emp;

//        // Iterate over the query results
//        foreach (var emp in query)
//        {
//            Console.WriteLine("Name: " + emp.Name);
//            Console.WriteLine("Age: " + emp.Age);
//            Console.WriteLine("Department: " + emp.Department);
//            Console.WriteLine();
//        }

//        Console.ReadLine();
//    }
//}


//Null types 
//public class Program
//{
//    static void Main(string[] args)
//    {
//        int a = 10;
//        int? b = null;
//        int? c = 20;

//        Console.WriteLine("Welcome");

//        int? z = b ?? c;
//        Console.WriteLine("z value" + " " + z); 
//    }
//}






