using BusinessServiceApp.Application.Implementation;
using System.Linq;

namespace BusinessServiceApp.Application.Services
{
    class BusinessITFactory : BusinessFactory
    {
        public override Business GetBusiness()
        {
            return new BusinessIT("SDAF234", "RDS11224", "SDD233", "SDDFGH", "CCVVA", "DDGGH", "DDFG234", Enums.LegalFormIT.SRL
                , Enums.BusinessCodeTypeIT.ATECO,
                new BusinessAddressIT("CCSS", "SD233", "Address 1", "Sohna", "North", "122103", "India", Enumerable.Empty<string>()),
                Enums.BusinessStatus.ACTIVE, "US", "VA11223", null, null, null);
        }
    }
}
