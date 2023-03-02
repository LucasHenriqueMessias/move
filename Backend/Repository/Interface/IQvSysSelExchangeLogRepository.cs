using oraclebam.Models;

namespace oraclebam.Repository.Interface
{
    public interface IQvSysSelExchangeLogRepository
    {
        Task<List<QvSysSelExchangeLog>> ListarExchangeLog();
        Task<QvSysSelExchangeLog> AddExchangeLog(QvSysSelExchangeLog ExchangeLog);
        Task<QvSysSelExchangeLog> UpdateExchangeLog(QvSysSelExchangeLog exchangeLog, long SelId);
        Task<QvSysSelExchangeLog> SearchExchangeLog(long SelId);
        Task<bool> DeleteExchangeLog(long SelId);
    }
}
