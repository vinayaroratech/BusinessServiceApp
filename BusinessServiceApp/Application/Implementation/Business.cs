using BusinessServiceApp.Application.Enums;
using BusinessServiceApp.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace BusinessServiceApp.Application.Implementation
{
    internal abstract class Business : IBusiness
    {
        public BusinessStatus Status { get; protected set; }
        public string CountryCode { get; protected set; }
        public string VATNumber { get; protected set; }
        public IEnumerable<(string code, string description)> BusinessCodes { get; protected set; }
        public DateTimeOffset? OperationalFrom { get; protected set; }
        public DateTimeOffset? OperationalTo { get; protected set; }
    }
}
