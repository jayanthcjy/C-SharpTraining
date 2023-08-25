
using System.Security.Cryptography;

public class CustomArgs : EventArgs
{
    public string Message;
    public CustomArgs(string str)
    {
        this.Message = str;
    }
}
public class Button
{
    public event EventHandler<CustomArgs> RaiseClick;

    public void ButtonClcik() {

        OnClick(new CustomArgs("Event Triggered"));
    }

    protected virtual void OnClick(CustomArgs e)
    {
       
        EventHandler<CustomArgs> raiseEvent = RaiseClick;

        // Event will be null if there are no subscribers
        if (raiseEvent != null)
        {
            // Format the string to send inside the CustomEventArgs parameter
            e.Message += $" at {DateTime.Now}";

            // Call to raise the event.
            raiseEvent(this, e);
        }
    }
}

public class ClickEvent
{
    public string id;

    public ClickEvent(string _id,Button bt )
    {
        bt.RaiseClick += HandleCustomEvent;
    }
    void HandleCustomEvent(object sender, CustomArgs e)
    {
        Console.WriteLine($"{id} button clicked: {e.Message}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Button bt = new Button();
        string input =Console.ReadLine();
        ClickEvent ce = new ClickEvent(input, bt);
        bt.ButtonClcik();

    }
}