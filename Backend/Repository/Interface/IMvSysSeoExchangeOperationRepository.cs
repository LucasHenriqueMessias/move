using oraclebam.Models;

namespace oraclebam.Repository.Interface
{
    public interface IMvSysSeoExchangeOperationRepository
    {
        Task<List<MvSysSeoExchangeOperation>> ListarExchangeOperation();
        Task<List<MvSysSeoExchangeOperation>> AddExchangeOperation(MvSysSeoExchangeOperation exchangeOperation);
        Task<List<MvSysSeoExchangeOperation>> UpdateExchangeOperation(MvSysSeoExchangeOperation exchangeOperation, string seoOperation);
        Task<bool> DeleteExchangeOperation(string seoOperation);
        Task<MvSysSeoExchangeOperation> SearchExchangeOperation(string seoOperation);

    }
}
