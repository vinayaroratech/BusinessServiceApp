using BusinessServiceApp.Application.Enums;

namespace BusinessServiceApp.Application.Interfaces
{
    internal interface IBusinessGB : IBusiness<LegalFormGB, BusinessCodeTypeGB, IBusinessAddress>
    {
        string CompanyNumber { get; }
    }
}
