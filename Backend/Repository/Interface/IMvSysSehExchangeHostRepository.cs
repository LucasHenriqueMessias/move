using oraclebam.Models;

namespace oraclebam.Repository.Interface
{
    public interface IMvSysSehExchangeHostRepository
    {
        Task<List<MvSysSehExchangeHost>> ListarExchangeHost();
        Task<MvSysSehExchangeHost> AddExchangeHost(MvSysSehExchangeHost exchangeHost);
        Task<MvSysSehExchangeHost> UpdateExchangeHost(MvSysSehExchangeHost exchangeHost, string SehCompany);
        Task<bool> DeleteExchangeHost(string SehCompany);
        Task<MvSysSehExchangeHost> SearchExchangeHost(string sehCompany);
    }
}
