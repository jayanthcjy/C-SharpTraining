using System;

public class Program
{
    public static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Original numbers:");
        PrintArray(numbers);

        // Pass the array by reference using 'in'
        MultiplyByTwo(in numbers, out int[] multipliedNumbers);

        Console.WriteLine("Multiplied numbers:");
        PrintArray(multipliedNumbers);
    }

    public static void MultiplyByTwo(in int[] inputArray, out int[] resultArray)
    {
        int length = inputArray.Length;
        resultArray = new int[length];

        for (int i = 0; i < length; i++)
        {
            resultArray[i] = inputArray[i] * 2;
        }
    }


    public static void PrintArray(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
    }
}
