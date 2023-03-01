using oraclebam.Models;

namespace oraclebam.Repository.Interface
{
    public interface IMvSysSjqJobQueueRepository
    {
        Task<List<MvSysSjqJobQueue>> APIJobQueues();
        Task<MvSysSjqJobQueue> UpdateQueue(MvSysSjqJobQueue q, string SjqProcedureName);
        Task<bool> DeleteQueue(string SjqProcedureName);
        Task<MvSysSjqJobQueue> SearchByProcedureName(string SjqProcedureName);
        Task<MvSysSjqJobQueue> AddQueue(MvSysSjqJobQueue q);
    }
}
