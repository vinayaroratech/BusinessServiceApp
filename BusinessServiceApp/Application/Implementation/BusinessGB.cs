using BusinessServiceApp.Application.Enums;
using BusinessServiceApp.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace BusinessServiceApp.Application.Implementation
{
    internal class BusinessGB : Business, IBusinessGB
    {
        public BusinessGB(
            string companyNumber,
            LegalFormGB legalForm,
            BusinessCodeTypeGB businessCodeType,
            IBusinessAddress businessAddressType,
            BusinessStatus status,
            string countryCode,
            string vATNumber,
            IEnumerable<(string code, string description)> businessCodes,
            DateTimeOffset? operationalFrom,
            DateTimeOffset? operationalTo)
        {
            CompanyNumber = companyNumber;
            LegalForm = legalForm;
            BusinessCodeType = businessCodeType;
            BusinessAddressType = businessAddressType;
            Status = status;
            CountryCode = countryCode;
            VATNumber = vATNumber;
            BusinessCodes = businessCodes;
            OperationalFrom = operationalFrom;
            OperationalTo = operationalTo;
        }

        public string CompanyNumber { get; private set; }
        public LegalFormGB LegalForm { get; private set; }
        public BusinessCodeTypeGB BusinessCodeType { get; private set; }
        public IBusinessAddress BusinessAddressType { get; private set; }
    }
}
