using oraclebam.Models;

namespace oraclebam.Repository.Interface
{
    public interface IQvSysSsmSystemMailRepository
    {
        Task<List<QvSysSsmSystemMail>> ListarEmailSistema();
        Task<QvSysSsmSystemMail> AddEmailSistema(QvSysSsmSystemMail Mail);
        Task<QvSysSsmSystemMail> UpdateEmailSistema(QvSysSsmSystemMail Mail, DateTime SsmSentDatetime);
        Task<QvSysSsmSystemMail> SearchEmailSistema(DateTime SsmSentDatetime);
        Task<bool> DeleteEmailSistema(DateTime SsmSentDatetime);
    }
}
