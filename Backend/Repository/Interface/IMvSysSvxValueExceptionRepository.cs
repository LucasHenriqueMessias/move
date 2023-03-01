using oraclebam.Models;

namespace oraclebam.Repository.Interface
{
    public interface IMvSysSvxValueExceptionRepository
    {
        Task<List<MvSysSvxValueException>> ValueExceptionAPI();
        Task<MvSysSvxValueException> AddValueException(MvSysSvxValueException e);
        Task<MvSysSvxValueException> UpdateValueException(MvSysSvxValueException e, string svxCompany);
        Task<bool> DeleteValueException(string SvxCompany);
        Task<MvSysSvxValueException> SearchByValue(string SvxCompany);
    }
}
