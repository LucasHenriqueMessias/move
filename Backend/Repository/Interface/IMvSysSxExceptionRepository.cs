using oraclebam.Models;

namespace oraclebam.Repository.Interface
{
    public interface IMvSysSxExceptionRepository
    {
        Task<List<MvSysSxException>> ExceptionAPI(); 
        Task<MvSysSxException> SearchByException(string sxCompany );
        Task<MvSysSxException> AddException(MvSysSxException Exception);
        Task<MvSysSxException> UpdateByException(MvSysSxException Exception , string sxCompany);
        Task<bool> DeleteByException(string sxCompany);
    }
}
