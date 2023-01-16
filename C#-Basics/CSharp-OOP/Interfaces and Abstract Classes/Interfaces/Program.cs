using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Program
    {
        private static Customer AddCustomer()
        {
            Console.Write("Enter customer information (FirstName LastName City Email Number): ");
            string[] input = Console.ReadLine().Split(' ');

            string firstName = input[0];
            string lastName = input[1];
            string city = input[2];
            string email = input[3];
            string number = input[4];

            return new Customer(firstName, lastName, city, email, number);
        }

        private static List<IPhysicalProductInfo> AddData()
        {
            List<IPhysicalProductInfo> output = new List<IPhysicalProductInfo>();

            Console.Write("Enter product name: ");
            string productName = Console.ReadLine();
            Console.Write("Enter product type: ");
            string productType = Console.ReadLine();

            output.Add(new PhysicalProduct { ProductName = productName, ProductType = productType });

            return output;
        }

        public static void Main(string[] args)
        {
            List<IPhysicalProductInfo> cart = AddData();
            List<ICustomerInfo> customerInfo = new List<ICustomerInfo>();
            List<IDigitalProductInfo> digitalCart = new List<IDigitalProductInfo>();

            Customer customer = AddCustomer();
            customerInfo.Add(customer);

            foreach (ICustomerInfo var in customerInfo)
            {
                Console.WriteLine($"{var.FirstName} {var.LastName} {var.PhoneNumber} {var.EmailAddress}");
            }

            foreach (IPhysicalProductInfo var in cart)
            {
                Console.WriteLine($"Product Type: {var.ProductType}, Product Name: {var.ProductName}, Order Status: {var.OrderCompletion}");
            }
        }
    }
}