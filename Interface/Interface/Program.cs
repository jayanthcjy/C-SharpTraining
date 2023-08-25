public interface IInter
{
    public int add();
    public void print()
    {
        Console.WriteLine("Inteface");
    }
}

public class program : IInter
{
    public int add()
    {
        return 0;
    }
    //public void print()
    //{
    //    Console.WriteLine("dvvjksgbn"); 
    //}

    static void Main(string[] args)
    {
        program program = new program(); 
    }

}