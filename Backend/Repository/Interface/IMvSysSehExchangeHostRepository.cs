using oraclebam.Models;

namespace oraclebam.Repository.Interface
{
    public interface IMvSysSehExchangeHostRepository
    {
        Task<List<MvSysSehExchangeHost>> ListarExchangeHost();
        Task<List<MvSysSehExchangeHost>> AddExchangeHost(List<MvSysSehExchangeHost> exchangeHost);
        Task<List<MvSysSehExchangeHost>> UpdateExchangeHost(MvSysSehExchangeHost exchangeHost, string SehCompany, List<MvSysSehExchangeHost> exchangeHostSehCompany);
        Task<bool> DeleteExchangeHost(string SehCompany);
        Task<MvSysSehExchangeHost> SearchExchangeHost(string SehCompany);
    }
}
