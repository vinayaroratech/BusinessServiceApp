using System.Collections.Generic;

namespace BusinessServiceApp.Application.Interfaces
{
    internal interface IBusinessAddress
    {
        string Address { get; }
        string Locality { get; }
        string Region { get; }
        string PostalCode { get; }
        string Country { get; }
        IEnumerable<string> AdditionalAddressLines { get; }
    }
}
