using BusinessServiceApp.Application.Enums;
using System;
using System.Collections.Generic;

namespace BusinessServiceApp.Application.Interfaces
{
    internal interface IBusiness
    {
        BusinessStatus Status { get; }
        string CountryCode { get; }
        string VATNumber { get; }
        IEnumerable<(string code, string description)> BusinessCodes { get; }
        DateTimeOffset? OperationalFrom { get; }
        DateTimeOffset? OperationalTo { get; }
    }
}
