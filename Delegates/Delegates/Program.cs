///// <summary>
///// Delegates
///// </summary>
//using System.Threading.Channels;

//class Program
//{
//    public delegate void MyDelegate(string message);
//    public delegate int AddDelegate(int a, int b);
//    public delegate void EventHandler(object? sender, EventArgs e);

//    static void Main()
//    {
//        // Create instances of the delegate and associate methods
//        MyDelegate delegate1 = MethodA;
//        MyDelegate delegate2 = MethodB;
//        Program obj1 = new Program();
//        AddDelegate addDel = obj1.Add;
//        int sum = addDel(1, 2);
//        Console.WriteLine($"Sum is : {sum}");


//        // Invoke the delegates, which call the associated methods
//        delegate1("Hello");
//        delegate2("World");
//        Action<int> aaa = delegate (int n)
//        {
//            Console.WriteLine();
//        };
//        Action<int> s=(int a)=>Console.WriteLine(a);
//    }

//    static void MethodA(string message)
//    {
//        Console.WriteLine("Method A: " + message);
//    }

//    static void MethodB(string message)
//    {
//        Console.WriteLine("Method B: " + message);
//    }

//    int Add(int a, int b) { return a + b; }
//}






//class Program
//{
//    delegate void MyDelegate(string message);

//    static void Main()
//    {
//        // Create an instance of the delegate using an anonymous method
//        MyDelegate delegate1 = delegate (string m)
//        {
//            Console.WriteLine("Anonymous Method: " + m);

//        };

//        // Invoke the delegate, which calls the anonymous method
//        delegate1("Hello");
//    }
//}







///// <summary>
///// Action
///// </summary>
//class Program
//{
//    static void Main()
//    {
//        // Example 1: Action with no parameters
//        Action greet = () =>
//        {
//            Console.WriteLine("Hello, World!");
//        };
//        greet(); // Invoke the action

//        // Example 2: Action with a single parameter
//        Action<string> displayMessage = (message) =>
//        {
//            Console.WriteLine(message);
//        };
//        displayMessage("This is a custom message"); // Invoke the action with an argument

//        // Example 3: Action with multiple parameters
//        Action<int, int> calculateSum = (x, y) =>
//        {
//            int sum = x + y;
//            Console.WriteLine("The sum is: " + sum);
//        };
//        calculateSum(5, 3); // Invoke the action with arguments

//        // Example 4: Action as a callback
//        PerformOperation(10, 3, calculateSum); // Pass the calculateSum action as a callback
//    }

//    static void PerformOperation(int x, int y, Action<int, int> callback)
//    {
//        callback(x, y); // Invoke the callback action
//    }
//}






/// <summary>
/// Anonynomus methods
/// </summary>
namespace DotNetEvents
{
    // Define a class to hold custom event info
    public class CustomEventArgs : EventArgs
    {
        public CustomEventArgs(string message)
        {
            Message = message;
        }

        public string Message;
    }

    // Class that publishes an event
    class Publisher
    {
        // Declare the event using EventHandler<T>
        public delegate void DelegateEvent(CustomEventArgs e);
        public event DelegateEvent RaiseCustomEvent;


        public void DoSomething()
        {
            // Write some code that does something useful here
            // then raise the event. You can also raise an event
            // before you execute a block of code.
            RaiseCustomEvent(new CustomEventArgs("Event triggered"));
        }

    }

    //Class that subscribes to an event
    class Subscriber
    {
        private readonly string _id;

        public Subscriber(string id, Publisher pub)
        {
            _id = id;

            // Subscribe to the event
            pub.RaiseCustomEvent += HandleCustomEvent;            
        } 


        // Define what actions to take when the event is raised.
        void HandleCustomEvent(CustomEventArgs e)
        {
            Console.WriteLine($"{_id} received this message: {e.Message}");
        }
    }



    class Program
    {
        static void Main()
        {
            var pub = new Publisher();
            var sub1 = new Subscriber("sub1", pub);
            var sub2 = new Subscriber("sub2", pub);


            // Call the method that raises the event.
            pub.DoSomething();
                        

            // Keep the console window open
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}

