using oraclebam.Models;

namespace oraclebam.Repository.Interface
{
    public interface IMvSysSvxValueExceptionRepository
    {
        Task<List<MvSysSvxValueException>> ValueExceptionAPI();
        Task<List<MvSysSvxValueException>> AddValueException(MvSysSvxValueException e);
        Task<List<MvSysSvxValueException>> UpdateValueException(MvSysSvxValueException e, string SvxCompany);
        Task<bool> DeleteValueException(string SvxCompany);
        Task<List<MvSysSvxValueException>> SearchByValue(string SvxCompany);
    }
}
