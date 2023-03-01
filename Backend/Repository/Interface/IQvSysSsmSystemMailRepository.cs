using oraclebam.Models;

namespace oraclebam.Repository.Interface
{
    public interface IQvSysSsmSystemMailRepository
    {
        Task<List<QvSysSsmSystemMail>> ListarEmailSistema();
    }
}
