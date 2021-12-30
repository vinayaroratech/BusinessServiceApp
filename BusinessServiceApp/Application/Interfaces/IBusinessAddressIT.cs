namespace BusinessServiceApp.Application.Interfaces
{
    internal interface IBusinessAddressIT : IBusinessAddress
    {
        string SiglaDellaProvincia { get; }
        string CodiceSede { get; }
    }
}
