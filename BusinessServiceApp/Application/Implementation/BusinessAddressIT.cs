using BusinessServiceApp.Application.Interfaces;
using System.Collections.Generic;

namespace BusinessServiceApp.Application.Implementation
{
    internal class BusinessAddressIT : BusinessAddress, IBusinessAddressIT
    {
        public BusinessAddressIT(string siglaDellaProvincia,
            string codiceSede,
            string address,
            string locality,
            string region,
            string postalCode,
            string country,
            IEnumerable<string> additionalAddressLines) : base(address, locality, region, postalCode, country, additionalAddressLines)
        {
            SiglaDellaProvincia = siglaDellaProvincia;
            CodiceSede = codiceSede;
        }

        public string SiglaDellaProvincia { get; private set; }
        public string CodiceSede { get; private set; }
    }
}
