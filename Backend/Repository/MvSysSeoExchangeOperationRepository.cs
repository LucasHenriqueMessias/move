using Microsoft.EntityFrameworkCore;
using oraclebam.Models;
using oraclebam.Repository.Interface;

namespace oraclebam.Repository
{
    public class MvSysSeoExchangeOperationRepository : IMvSysSeoExchangeOperationRepository
    {
        private readonly ModelContext _dbContext;
        public MvSysSeoExchangeOperationRepository(ModelContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<MvSysSeoExchangeOperation>> AddExchangeOperation(MvSysSeoExchangeOperation exchangeOperation)
        {
            await _dbContext.MvSysSeoExchangeOperations.AddAsync(exchangeOperation);
            await _dbContext.SaveChangesAsync();
            return exchangeOperation;
        }

        public async Task<bool> DeleteExchangeOperation(string seoOperation)
        {
            MvSysSeoExchangeOperation exchangeOperation = await SearchExchangeOperation(seoOperation) ?? throw new Exception("Operação para exclusão não encontrada.");
            _dbContext.MvSysSeoExchangeOperations.Remove(exchangeOperation);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<MvSysSeoExchangeOperation>> ListarExchangeOperation()
        {
            var retorno = await _dbContext.MvSysSeoExchangeOperations.ToListAsync();
            return retorno;
        }

        public async Task<MvSysSeoExchangeOperation> SearchExchangeOperation(string seoOperation)
        {
            return await _dbContext.MvSysSeoExchangeOperations.FirstOrDefaultAsync(x => x.SeoOperation == seoOperation);
        }

        public async Task<List<MvSysSeoExchangeOperation>> UpdateExchangeOperation(MvSysSeoExchangeOperation exchangeOperation, string seoOperation)
        {
            MvSysSeoExchangeOperation exchange = await SearchExchangeOperation(seoOperation);

            if (exchangeOperation == null)
            {
                throw new Exception("Operação para exclusão não encontrada.");
            }

            exchange.SeoCompany = exchangeOperation.SeoCompany;
            exchange.SeoDateAlt= exchangeOperation.SeoDateAlt;
            exchange.SeoUserAlt= exchangeOperation.SeoUserAlt;
            exchange.SeoDescription= exchangeOperation.SeoDescription;
            exchange.SeoDestFtpUser = exchangeOperation.SeoDestFtpUser;
            exchange.SeoDestHost= exchangeOperation.SeoDestHost;
            exchange.SeoOperation = exchangeOperation.SeoOperation;
            exchange.SeoSourceFtpUser= exchangeOperation.SeoSourceFtpUser;
            exchange.SeoSourceHost= exchangeOperation.SeoSourceHost;   
   
            _dbContext.MvSysSeoExchangeOperations.Update(exchange);

            return exchange;
        }
    }
}
