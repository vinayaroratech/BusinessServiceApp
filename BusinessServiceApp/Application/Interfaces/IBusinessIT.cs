using BusinessServiceApp.Application.Enums;

namespace BusinessServiceApp.Application.Interfaces
{
    internal interface IBusinessIT : IBusiness<LegalFormIT, BusinessCodeTypeIT, IBusinessAddressIT>
    {
        string CodeceFiscale { get; }
        string REA { get; }
        string SiglaDellaProvinciaSede { get; }
        string ProvinciaSede { get; }
        string CCIAA { get; }
        string DescrizioneCCIAA { get; }
        string IndirizzoPostaCertificata { get; }
    }
}
