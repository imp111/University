using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class PhysicalProduct : IPhysicalProductInfo, IDigitalProductInfo
    {
        public string ProductType { get; set; }

        public string ProductName { get; set; }

        public bool OrderCompletion { get; set; }
        public bool EmailSent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ItemShippment(Customer customer)
        {
            Console.WriteLine($"Item: | {ProductType} | {ProductName} | is shipped to {customer.FirstName} {customer.LastName} from {customer.City}");
            Console.WriteLine($"Email: {customer.EmailAddress}, phone number: {customer.PhoneNumber}");
            OrderCompletion = true;
        }

        public void SendEmail(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}