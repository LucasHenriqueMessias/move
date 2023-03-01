using oraclebam.Models;

namespace oraclebam.Repository.Interface
{
    public interface IMvSysSegEmailGroupRepository
    {
        Task<List<MvSysSegEmailGroup>> ListarEmails();
        Task<MvSysSegEmailGroup> AddEmail(MvSysSegEmailGroup emailGroup);
        Task<MvSysSegEmailGroup> UpdateEmail(MvSysSegEmailGroup EmailGroup, string segGroupName );
        Task<bool> DeleteEmail( string segGroupName );
        Task<MvSysSegEmailGroup> SearchByGroupEmail( string segGroupName );
    }
}
