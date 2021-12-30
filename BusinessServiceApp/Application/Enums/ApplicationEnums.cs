namespace BusinessServiceApp.Application.Enums
{
    public enum BusinessStatus
    {
        ACTIVE,
        DISSOLVED
    }

    public enum LegalFormGB
    {
        LTD = 0,
        PLC = 1,
        GP = 2,
        LLP = 3,
        GUARANTEE = 4,
        UNTLD = 5,
        CI = 6,
        RC = 7,
        PTP = 8,
    }

    public enum BusinessCodeTypeGB
    {
        SIC = 0,
        NAICS = 1,
        NDY = 2,
        NACE = 3,
    }

    public enum BusinessCodeTypeIT
    {
        ATECO = 0,
    }

    public enum LegalFormIT
    {
        SRL = 0,
        SPA = 1,
        SNC = 2,
        SAS = 3,
        SAPA = 8,
        SCARL = 9,
        SCPA = 10
    }
}
