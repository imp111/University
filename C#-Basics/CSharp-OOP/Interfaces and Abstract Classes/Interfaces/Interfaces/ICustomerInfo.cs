using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICustomerInfo
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string City { get; set; }
        string EmailAddress { get; set; }
        string PhoneNumber { get; set; }
        bool DisplayInfoSuccess { get; set; }

        void CheckEmailStatus();
    }
}