using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first1
{
    public class Class2 : IDisposable
    {
        public int a;
        public int b;

       public  Class2(int aa,int bb) {
            a= aa; b = bb;
        
        }
        ~Class2() {

            Dispose(false);
            Console.WriteLine("Class2 Destructor and despose");
        
        }
        public void Dispose()
        {
            Dispose(disposing: true);

            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Console.WriteLine("Cleaned the objects");
            }
        }


    }
}
