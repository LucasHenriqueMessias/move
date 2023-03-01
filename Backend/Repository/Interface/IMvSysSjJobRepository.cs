using oraclebam.Models;

namespace oraclebam.Repository.Interface
{
    public interface IMvSysSjJobRepository
    {
        Task<List<MvSysSjJob>> APISjJob();
        Task<MvSysSjJob> AddJob(MvSysSjJob job);
        Task<MvSysSjJob> UpdateJob(MvSysSjJob job, string ProcedureName);
        Task<bool> DeleteJob(string ProcedureName);
        Task<MvSysSjJob> SearchJob(string ProcedureName);
    }
}
