
using System;
class HelloWorld
{
    static void Main()
    {
        string float1 = Console.ReadLine();
        string float2 = Console.ReadLine();
        Logic obj = new Logic();
        string ans = obj.FloatAddition(float1, float2);
    }
}