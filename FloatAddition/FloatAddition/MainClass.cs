using System;


namespace AdditionOfFloatNumbers
{   
    /// <summary>
    /// This class gives the addtion of two float numbers
    /// </summary>
    public class Program
    {
        /// <summary>
        /// This method takes two inputs from users and send to FloatAddition class
        /// </summary>
        static void Main(string[] args)
        {
            string floatInput1 = Console.ReadLine();
            string floatInput2 = Console.ReadLine();

            Validation val= new Validation();
            if (val.Validate(floatInput1, floatInput2) == true){

                FloatAddition obj = new FloatAddition();
                Console.WriteLine(obj.Addition(floatInput1, floatInput2));
            }
        }
    }
}
