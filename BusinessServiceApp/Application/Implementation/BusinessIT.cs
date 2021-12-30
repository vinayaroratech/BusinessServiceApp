using BusinessServiceApp.Application.Enums;
using BusinessServiceApp.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace BusinessServiceApp.Application.Implementation
{
    internal class BusinessIT : Business, IBusinessIT
    {
        public BusinessIT(
            string codeceFiscale,
            string rEA,
            string siglaDellaProvinciaSede,
            string provinciaSede,
            string cCIAA,
            string descrizioneCCIAA,
            string indirizzoPostaCertificata,
            LegalFormIT legalForm,
            BusinessCodeTypeIT businessCodeType,
            IBusinessAddressIT businessAddressType,
            BusinessStatus status,
            string countryCode,
            string vATNumber,
            IEnumerable<(string code, string description)> businessCodes,
            DateTimeOffset? operationalFrom,
            DateTimeOffset? operationalTo)
        {
            CodeceFiscale = codeceFiscale;
            REA = rEA;
            SiglaDellaProvinciaSede = siglaDellaProvinciaSede;
            ProvinciaSede = provinciaSede;
            CCIAA = cCIAA;
            DescrizioneCCIAA = descrizioneCCIAA;
            IndirizzoPostaCertificata = indirizzoPostaCertificata;
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

        public string CodeceFiscale { get; private set; }
        public string REA { get; private set; }
        public string SiglaDellaProvinciaSede { get; private set; }
        public string ProvinciaSede { get; private set; }
        public string CCIAA { get; private set; }
        public string DescrizioneCCIAA { get; private set; }
        public string IndirizzoPostaCertificata { get; private set; }
        public LegalFormIT LegalForm { get; private set; }
        public BusinessCodeTypeIT BusinessCodeType { get; private set; }
        public IBusinessAddressIT BusinessAddressType { get; private set; }
    }
}
