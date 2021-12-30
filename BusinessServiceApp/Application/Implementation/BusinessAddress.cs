using BusinessServiceApp.Application.Interfaces;
using System.Collections.Generic;

namespace BusinessServiceApp.Application.Implementation
{
    internal class BusinessAddress : IBusinessAddress
    {
        public BusinessAddress(
            string address,
            string locality,
            string region,
            string postalCode,
            string country,
            IEnumerable<string> additionalAddressLines)
        {
            Address = address;
            Locality = locality;
            Region = region;
            PostalCode = postalCode;
            Country = country;
            AdditionalAddressLines = additionalAddressLines;
        }

        public string Address { get; private set; }
        public string Locality { get; private set; }
        public string Region { get; private set; }
        public string PostalCode { get; private set; }
        public string Country { get; private set; }
        public IEnumerable<string> AdditionalAddressLines { get; private set; }
    }
}
