using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class DigitalProduct : IDigitalProductInfo, IPhysicalProductInfo
    {
        public string ProductName { get; set; }

        public bool EmailSent { get; set; }
        public string ProductType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool OrderCompletion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ItemShippment(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void SendEmail(Customer customer)
        {
            Console.WriteLine($"Email sent to {customer.EmailAddress}, for product | {ProductName} |");
            EmailSent = true;
        }
    }
}