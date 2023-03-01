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

        public async Task<List<QvSysSelExchangeLog>> ListarExchangeLog()
        {
            var retorno = await _dbContext.QvSysSelExchangeLogs.ToListAsync();
            return retorno;
        }

       
    }
}
