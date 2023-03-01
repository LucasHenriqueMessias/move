using oraclebam.Models;

namespace oraclebam.Repository.Interface
{
    public interface IMvSysSjJobRepository
    {
        Task<List<MvSysSjJob>> APISjJob();
        Task<List<MvSysSjJob>> AddJob(MvSysSjJob job);
        Task<List<MvSysSjJob>> UpdateJob(MvSysSjJob job, string ProcedureName );
        Task<bool> DeleteJob(string ProcedureName);
        Task<List<MvSysSjJob>> SearchJob(string ProcedureName);
    }
}
