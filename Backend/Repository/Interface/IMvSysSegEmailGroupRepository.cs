using oraclebam.Models;

namespace oraclebam.Repository.Interface
{
    public interface IMvSysSegEmailGroupRepository
    {
        Task<List<MvSysSegEmailGroup>> ListarEmails();
        Task<List<MvSysSegEmailGroup>> AddEmail(MvSysSegEmailGroup EmailGroup);
        Task<List<MvSysSegEmailGroup>> UpdateEmail(MvSysSegEmailGroup EmailGroup, string SegGroupName );
        Task<bool> DeleteEmail( string SegGroupName );
        Task<MvSysSegEmailGroup> SearchByGroupEmail( string SegGroupName );
    }
}
