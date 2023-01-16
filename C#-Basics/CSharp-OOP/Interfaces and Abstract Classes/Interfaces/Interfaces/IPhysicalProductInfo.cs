using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IPhysicalProductInfo
    {
        string ProductType { get; set; }

        string ProductName { get; set; }

        bool OrderCompletion { get; set; }

        void ItemShippment(Customer customer);
    }
}