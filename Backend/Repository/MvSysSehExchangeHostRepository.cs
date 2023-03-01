using Microsoft.EntityFrameworkCore;
using oraclebam.Models;
using oraclebam.Repository.Interface;

namespace oraclebam.Repository
{
    public class MvSysSehExchangeHostRepository : IMvSysSehExchangeHostRepository
    {
        private readonly ModelContext _dbContext;
        public MvSysSehExchangeHostRepository(ModelContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<MvSysSehExchangeHost> AddExchangeHost(MvSysSehExchangeHost exchangeHost)
        {
            await _dbContext.MvSysSehExchangeHosts.AddAsync(exchangeHost);
            await _dbContext.SaveChangesAsync();
            return exchangeHost;
        }

        public async Task<bool> DeleteExchangeHost(string SehCompany)
        {
            MvSysSehExchangeHost ExchangeHostSehCompany = await SearchExchangeHost(SehCompany) ?? throw new Exception("Company para exclusão não encontrado.");
            _dbContext.MvSysSehExchangeHosts.Remove(ExchangeHostSehCompany);
            await _dbContext.SaveChangesAsync() ;
            return true;
        }

        public async Task<List<MvSysSehExchangeHost>> ListarExchangeHost()
        {
            var retorno = await _dbContext.MvSysSehExchangeHosts.ToListAsync();
            return retorno;
        }

        public async Task<MvSysSehExchangeHost> SearchExchangeHost(string sehCompany)
        {
            return await _dbContext.MvSysSehExchangeHosts.FirstOrDefaultAsync(x => x.SehCompany == sehCompany);
        }

        public async Task<MvSysSehExchangeHost> UpdateExchangeHost(MvSysSehExchangeHost exchangeHost, string SehCompany)
        {
            MvSysSehExchangeHost ExchangeHostSehCompany = await SearchExchangeHost(SehCompany) ?? throw new Exception("Username para atualização não encontrado.");
            ExchangeHostSehCompany.SehPortFtp = exchangeHost.SehPortFtp;
            ExchangeHostSehCompany.SehCompany= exchangeHost.SehCompany;
            ExchangeHostSehCompany.SehDateAlt = exchangeHost.SehDateAlt;
            ExchangeHostSehCompany.SehFileProtocol= exchangeHost.SehFileProtocol;
            ExchangeHostSehCompany.SehHost = exchangeHost.SehHost;
            ExchangeHostSehCompany.SehPassword= exchangeHost.SehPassword;
            ExchangeHostSehCompany.SehUserAlt= exchangeHost.SehUserAlt;
            ExchangeHostSehCompany.SehUsername = exchangeHost.SehUsername;

            _dbContext.MvSysSehExchangeHosts.Update(ExchangeHostSehCompany);
            await _dbContext.SaveChangesAsync();

            return ExchangeHostSehCompany; 
        }
    }
}
