using BusinessServiceApp.Application.Implementation;
using System.Linq;

namespace BusinessServiceApp.Application.Services
{
    class BusinessGBFactory : BusinessFactory
    {
        public override Business GetBusiness()
        {
            return new BusinessGB("COM123", Enums.LegalFormGB.CI, Enums.BusinessCodeTypeGB.NAICS,
                new BusinessAddress("Address 1", "Sohna", "North", "122103", "India", Enumerable.Empty<string>()),
                 Enums.BusinessStatus.ACTIVE, "IND", "VA123312", null, null, null);
        }
    }
}
