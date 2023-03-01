using oraclebam.Models;

namespace oraclebam.Repository.Interface
{
    public interface IMvSysSxExceptionRepository
    {
        Task<List<MvSysSxException>> ExceptionAPI(); 
        Task<MvSysSxException> SearchByException(string sxCompany );
    }
}
