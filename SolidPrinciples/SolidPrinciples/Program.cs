using System;
using System.Globalization;
using IIntermediate;

// Single Responsibility Principle
class EmailSender
{
    public void SendEmail(string user, string subject, string message)
    {
        Console.WriteLine("Sending email to: " + user);
        // Sending email logic here...
    }
}

// Open/Closed Principle
interface ICommonCategories
{
    void Watches();
    void Caps();
}

class MensCategories : ICommonCategories
{
    public void Watches()
    {
        Console.WriteLine("Watches for men");
       
    }

    public void Caps()
    {
        Console.WriteLine("Caps for men");
    }
}

class WomensCategories : ICommonCategories
{
    public void Watches()
    {
        Console.WriteLine("Watches for women");
    }
    public void Caps()
    {
        Console.WriteLine("Caps for women");

    }
}

// Liskov Substitution Principle
public interface IOrders
{
    void OrderDetails();
}

public class NewOrders: IOrders
{
   public void OrderDetails()
    {
        Console.WriteLine("New orders details");
    }

}
public class TotalOrders : NewOrders
{
    public void OrderDetails()
    {
        Console.WriteLine("All orders details");
    }

}



// Application entry point
class Program
{
    static void Main()
    {
        //Single response
        EmailSender sender1 = new EmailSender();
        sender1.SendEmail("Anurag", "Black Friday", "Hi Anurag, \n Grabe your offer by shoping above 1999/Rs and get 50% off");
        
        //open/closed
        MensCategories men1Obj=new MensCategories();
        men1Obj.Watches();
        WomensCategories womensObj1=new WomensCategories();
        womensObj1.Caps();

        // Liskov
        IOrders ordersDetails = new NewOrders();
        ordersDetails.OrderDetails();
        ordersDetails = new TotalOrders();
        ordersDetails.OrderDetails();
        
        //Dpendency inversion
        IInventory inventoryItems = new InventoryFactory().InventoryFactoryObject();
        inventoryItems.ProfitPercentOnItems(1);
        inventoryItems.ProfitPercentOnItems(2);

       
        Console.ReadKey();
    }
}
