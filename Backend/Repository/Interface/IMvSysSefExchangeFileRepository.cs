using oraclebam.Models;

namespace oraclebam.Repository.Interface
{
    public interface IMvSysSefExchangeFileRepository
    {
        Task<List<MvSysSefExchangeFile>> ListarExchangeFile();
        Task<MvSysSefExchangeFile> AddExchangeFile(MvSysSefExchangeFile exchangeFile);
        Task<MvSysSefExchangeFile> UpdateExchangeFile(MvSysSefExchangeFile exchangeFile, long SefID);
        Task<bool> DeleteExchangeFile(long SefID);
        Task<MvSysSefExchangeFile> SearchExchangeFile(long SefID);
    }
}
