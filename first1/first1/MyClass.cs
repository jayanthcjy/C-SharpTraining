using System;
using System.IO;

public class MyClass : IDisposable
{
    private bool disposed = false;
    public FileStream f;

    public MyClass() {
              
        f = File.Open("C:\\Users\\Jayanth C\\Downloads\\MaxProdOf4Digits.txt",FileMode.Open,FileAccess.ReadWrite);
       
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public void Clean()
    {
        if (f != null)
        {
            f.Close();
            Console.WriteLine("f is closed");
        }
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                // Release managed resources here
            }

            Clean();
            // Release unmanaged resources here

            disposed = true;
        }
    }


    public void Hi()
    {
        if (true)
        {
            throw new Exception("saw");
        }
    }

    // Destructor (finalizer)
    ~MyClass()
    {
        Dispose(false);
    }
}
