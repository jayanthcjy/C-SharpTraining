
public class Program 
{
    public static void Main()
    {
        string s = "1234567";
        int n;
        int ap = 10;
        int nm = ap++;
        bool result=int.TryParse(s, out n);
       Console.WriteLine(n);
        //int n = int.Parse(s);
        //Console.WriteLine(n);
        string s1 = "12.23";
        //string s1 = "12.23";
        long l = 23299999;
        //int b = Convert.ToInt32(s);
        float b1 = float.Parse(s1);
        int c = (int)l;
        //int c1=Convert.ToInt32(l);
        string s2 = "123456789";
        //Console.WriteLine(c);
        int a = 12341277;
        string sa = Convert.ToString(a);
        float sa1 = 12.3f;
        //int saa=float.Parse(sa1);
        int num = 97415852;
        char ch=(char)num;
        Console.WriteLine("char"+ch);

        Complex mc1 = new Complex(1.5f, 2.5f);
        mc1.ShowXY();
        Complex mc2 = new Complex(1.5f, 2.5f);
        mc2.ShowXY();
        Complex mc3 = new Complex();
        mc3 = mc1 >= mc2;
        mc3.ShowXY();

    }


    // Binary operator overloading
    // Author: rajeshvs@msn.com
    public class Complex
    {
        private float x;
        private float y;
        public Complex()
        {
        }
        public Complex(float i, float j)
        {
            x = i;
            y = j;
        }
        public void ShowXY()
        {
            Console.WriteLine("{0} {1}", x, y);
        }
        public static Complex operator >=(Complex c1, Complex c2)
        {
            Complex temp = new Complex();
            temp.x = c1.x + c2.x;
            temp.y = c1.y + c2.y;
            return temp;
        }
        public static Complex operator <=(Complex c1, Complex c2)
        {
            Complex temp = new Complex();
            temp.x = c1.x + c2.x;
            temp.y = c1.y + c2.y;
            return temp;
        }
    }

    class MyComplex : Complex
    {
        private double x;
        private double y;
        public MyComplex(double i, double j)
        {
            x = i;
            y = j;
        }
        public MyComplex()
        {
        }
        public new void ShowXY()
        {
            Console.WriteLine("{0} {1}", x, y);
        }
    }
}
