using Microsoft.EntityFrameworkCore;
using oraclebam.Models;
using oraclebam.Repository.Interface;

namespace oraclebam.Repository
{
    public class QvSysSelExchangeLogRepository : IQvSysSelExchangeLogRepository
    {
        private readonly ModelContext _dbContext;
        public QvSysSelExchangeLogRepository(ModelContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<QvSysSelExchangeLog> AddExchangeLog(QvSysSelExchangeLog ExchangeLog)
        {
            await _dbContext.QvSysSelExchangeLogs.AddAsync(ExchangeLog);
            await _dbContext.SaveChangesAsync();
            return ExchangeLog;
        }

        public async Task<bool> DeleteExchangeLog(long SelId)
        {
            QvSysSelExchangeLog exchangeLog = await SearchExchangeLog(SelId) ?? throw new Exception("ID não encontrado para exclusão do Exchange Log");
            _dbContext.QvSysSelExchangeLogs.Remove(exchangeLog);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<QvSysSelExchangeLog>> ListarExchangeLog()
        {
            var retorno = await _dbContext.QvSysSelExchangeLogs.ToListAsync();
            return retorno;
        }

        public async Task<QvSysSelExchangeLog> SearchExchangeLog(long SelId)
        {
            return await _dbContext.QvSysSelExchangeLogs.FirstOrDefaultAsync(x => x.SelId == SelId);    
        }

        public async Task<QvSysSelExchangeLog> UpdateExchangeLog(QvSysSelExchangeLog exchangeLog, long SelId)
        {
            QvSysSelExchangeLog selExchange = await SearchExchangeLog(SelId) ?? throw new Exception("ID não encontrado para atualização do Exchange Log");
            selExchange.SelCompany = exchangeLog.SelCompany;
            selExchange.SelDate = exchangeLog.SelDate;
            selExchange.SelDateAlt  = exchangeLog.SelDateAlt;
            selExchange.SelId = SelId;
            selExchange.SelMessage = exchangeLog.SelMessage;
            selExchange.SelType = exchangeLog.SelType;
            selExchange.SelUserAlt = exchangeLog.SelUserAlt;


            _dbContext.QvSysSelExchangeLogs.Update(selExchange);
            await _dbContext.SaveChangesAsync();

            return selExchange;
        }
    }
}
