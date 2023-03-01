using oraclebam.Models;

namespace oraclebam.Repository.Interface
{
    public interface IMvSysSefExchangeFileRepository
    {
        Task<List<MvSysSefExchangeFile>> ListarExchangeFile();
        Task<List<MvSysSefExchangeFile>> AddExchangeFile(MvSysSefExchangeFile exchangeFile);
        Task<List<MvSysSefExchangeFile>> UpdateExchangeFile(MvSysSefExchangeFile exchangeFile, long SefID);
        Task<bool> DeleteExchangeFile(long SefID);
        Task<MvSysSefExchangeFile> SearchExchangeFile(long SefID);
    }
}
