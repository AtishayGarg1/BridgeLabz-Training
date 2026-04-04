/// <summary>
/// Defines a contract for a checkout system that supports adding customers to a queue,
/// removing customers after billing, and displaying available item prices.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_collections.scenariobased.smarthome
{
    internal interface ICheckout
    {
        void AddACustomer();
        void RemoveCustomer();
        void FetchItemPrice();
    }
}
