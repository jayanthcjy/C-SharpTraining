public class ClassA
{
    public static void Main()
    {
        int x = 0;
        int div = 0;
        try
        {
           //  throw new Exception("throw");

            div = 100 / x;
            Console.WriteLine("This linein not executed");

        }
        catch (DivideByZeroException ex)
        {

            Console.WriteLine(ex.Message);
        }
       
        finally
        {

            Console.WriteLine("Finally block");
        }
        Console.WriteLine($"Result is {div}");
    }
}