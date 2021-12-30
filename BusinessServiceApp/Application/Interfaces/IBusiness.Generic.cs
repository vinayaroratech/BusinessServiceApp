using System;

namespace BusinessServiceApp.Application.Interfaces
{
    internal interface IBusiness<TLegalForm, TBusinessCodeType, TBusinessAddressType> : IBusiness
        where TLegalForm : Enum
        where TBusinessCodeType : Enum
        where TBusinessAddressType : IBusinessAddress
    {
        TLegalForm LegalForm { get; }
        TBusinessCodeType BusinessCodeType { get; }
        TBusinessAddressType BusinessAddressType { get; }
    }
}
