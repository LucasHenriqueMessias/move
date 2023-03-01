using oraclebam.Models;

namespace oraclebam.Repository.Interface
{
    public interface IMvSysSeoExchangeOperationRepository
    {
        Task<List<MvSysSeoExchangeOperation>> ListarExchangeOperation();
        Task<MvSysSeoExchangeOperation> AddExchangeOperation(MvSysSeoExchangeOperation exchangeOperation);
        Task<MvSysSeoExchangeOperation> UpdateExchangeOperation(MvSysSeoExchangeOperation exchangeOperation, string seoOperation);
        Task<bool> DeleteExchangeOperation(string seoOperation);
        Task<MvSysSeoExchangeOperation> SearchExchangeOperation(string seoOperation);

    }
}
