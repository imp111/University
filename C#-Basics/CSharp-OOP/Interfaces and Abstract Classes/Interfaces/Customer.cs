using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Customer : ICustomerInfo, IDigitalProductInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public bool DisplayInfoSuccess { get; set; }
        public string ProductName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool EmailSent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Customer(string firstName, string lastName, string city, string emailAddress, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
        }

        public void CheckEmailStatus()
        {
            if (EmailSent == true)
            {
                Console.WriteLine("Email sent successfuly");
            }
            else
            {
                Console.WriteLine("Email not sent");
            }
        }

        public void SendEmail(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}