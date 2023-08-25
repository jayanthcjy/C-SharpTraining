using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AsynchronousProgramming
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string xmlFilePath = "C:\\Users\\Jayanth C\\source\\repos\\AsynchronousProgrammingAssignment\\AsynchronousProgramming\\XmlData.xml"; // Replace with the actual path to your XML file



            if (!File.Exists(xmlFilePath))
            {
                Console.WriteLine("XML file not found.");
                return;
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();



            try
            {
                XDocument XmlData = XDocument.Load(xmlFilePath);

                // Asynchronously retrieve values from XML elements
                Task<string> orderId = TimeResponseOfProperty(XmlData.Root?.Element("ID"));
                Task<string> orderRequestDate = TimeResponseOfProperty(XmlData.Root?.Element("RequestedShipDate"));
                Task<string> createdBy = TimeResponseOfProperty(XmlData.Root?.Element("CreatedBy"));

                // Asynchronously calculate sum of load factors, quantities, and prices

                var loadTasks = XmlData.Root.Elements("Items").Elements("Item").Select(item => TimeResponseOfProperty(item.Element("LOADFACTOR")));
                double totalLoad = (await Task.WhenAll(loadTasks)).Sum(item => double.Parse(item ?? "0"));

                var quantityTasks = XmlData.Root.Elements("Items").Elements("Item").Select(item => TimeResponseOfProperty(item.Element("Order_Quantity")));
                int totalQuantity = (await Task.WhenAll(quantityTasks)).Sum(item => int.Parse(item ?? "0"));

                var priceTasks = XmlData.Root.Elements("Items").Elements("Item").Select(item => TimeResponseOfProperty(item.Element("USPrice")));
                decimal totalPrice = (await Task.WhenAll(priceTasks)).Sum(item => decimal.Parse(item ?? "0"));

                // Asynchronously retrieve customer information
                Task<string> customerName = TimeResponseOfProperty(XmlData.Root?.Element("CustomerInfo")?.Element("Billing")?.Element("Name"));
                Task<string> customerAddress = TimeResponseOfProperty(XmlData.Root?.Element("CustomerInfo")?.Element("Billing")?.Element("Address1"));
                Task<string> customerPhone = TimeResponseOfProperty(XmlData.Root?.Element("CustomerInfo")?.Element("Billing")?.Element("Phone"));
                Task<string> customerEmail = TimeResponseOfProperty(XmlData.Root?.Element("CustomerInfo")?.Element("Billing")?.Element("DeliveryReceiptEmail"));


                // Wait for all tasks to complete
                await Task.WhenAll(orderId, orderRequestDate, createdBy, customerName, customerAddress, customerPhone, customerEmail);

                stopwatch.Stop();

                // Generate and print the output
                Console.WriteLine("Order Summary:");
                Console.WriteLine($"Order ID: {orderId.Result}");
                Console.WriteLine($"Order Request Date: {orderRequestDate.Result}");
                Console.WriteLine($"Created By: {createdBy.Result}");
                Console.WriteLine($"Load of the Order: {totalLoad}");
                Console.WriteLine($"Quantities of the Order: {totalQuantity}");
                Console.WriteLine($"Price: {totalPrice}");
                Console.WriteLine($"Customer Name: {customerName.Result}");
                Console.WriteLine($"Customer Address: {customerAddress.Result}");
                Console.WriteLine($"Customer Phone: {customerPhone.Result}");
                Console.WriteLine($"Customer Email: {customerEmail.Result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing XML: {ex.Message}");
            }

            Console.WriteLine($"Total response time: {stopwatch.ElapsedMilliseconds} ms");
        }


        // Method to measure response time of an XML element property
        static async Task<string> TimeResponseOfProperty(XElement element)
        {
            if (element != null)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                string value = element.Value.Trim();
                stopwatch.Stop();
                Console.WriteLine($"Response time for '{element.Name.LocalName}': {stopwatch.ElapsedMilliseconds} ms");
                return await Task.FromResult(value);
            }
            return null;
        }

    }
}