using oraclebam.Models;

namespace oraclebam.Repository.Interface
{
    public interface IQvSysSelExchangeLogRepository
    {
        Task<List<QvSysSelExchangeLog>> ListarExchangeLog();
    }
}
