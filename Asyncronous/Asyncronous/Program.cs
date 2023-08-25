using System;
using System.Net.Http;
using System.Threading.Tasks;

public class Program
{
    static async Task Main()
    {
        try
        {
            string apiUrl = "https://jsonplaceholder.typicode.com/posts/1";

            // Make an asynchronous web request using HttpClient



            // Handle the result
            await GetDataAsync(apiUrl);              for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(1);
            }
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    static async Task<string> GetDataAsync(string apiUrl)
    {
        // Create a new instance of HttpClient
        using (var httpClient = new HttpClient())
        {
            Console.WriteLine("GetDataAsync");
            // Make an asynchronous GET request to the API
            HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

            // Check if the request was successful
            response.EnsureSuccessStatusCode();

            // Read the response content as a string
            string data = await response.Content.ReadAsStringAsync();
            for (int i = 0; i < 100; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine(data);

            return data;
        }
    }
}



///Parellel programming
//using System;
//using System.Threading.Tasks;

//public class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//        // Calculate the square of each number in parallel
//        Parallel.For(0, numbers.Length, i =>
//        {
//            int squared = numbers[i] * numbers[i];
//            Console.WriteLine($"Square of {numbers[i]} is {squared}");

//        });
//        Console.ReadKey();
//    }
//}




///Exceptions

//using System;
//using System.Net.Http;
//using System.Threading.Tasks;

//public class Program
//{
//    static async Task Main()
//    {
//        try
//        {
//            string apiUrl = "https://jsonplaceholder.typicode.com/posts/100000"; // Non-existing URL to simulate a 404 error

//            // Make an asynchronous web request using HttpClient
//            string result = await GetDataAsync(apiUrl);

//            // Handle the result
//            Console.WriteLine(result);
//        }
//        catch (HttpRequestException ex)
//        {
//            Console.WriteLine($"HTTP Request Error: {ex.Message}");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"An error occurred: {ex.Message}");
//        }
//    }

//    static async Task<string> GetDataAsync(string apiUrl)
//    {
//        using (var httpClient = new HttpClient())
//        {
//            // Make an asynchronous GET request to the API
//            HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

//            // Check if the request was successful
//            response.EnsureSuccessStatusCode();

//            // Read the response content as a string
//            string data = await response.Content.ReadAsStringAsync();

//            return data;
//        }
//    }
//}

