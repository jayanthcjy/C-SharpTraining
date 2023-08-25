namespace DemoApplication.Services
{
    public class EmailMessage:IEmailMessage
    {
        public void Send(string message)
        {
            Console.WriteLine(message);
        }
    }
}
