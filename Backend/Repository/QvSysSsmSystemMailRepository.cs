using Microsoft.EntityFrameworkCore;
using oraclebam.Models;
using oraclebam.Repository.Interface;

namespace oraclebam.Repository
{
    public class QvSysSsmSystemMailRepository : IQvSysSsmSystemMailRepository
    {
        private readonly ModelContext _context;

        public QvSysSsmSystemMailRepository(ModelContext context)
        {
            _context = context;
        }

        public async Task<QvSysSsmSystemMail> AddEmailSistema(QvSysSsmSystemMail Mail)
        {
            await _context.QvSysSsmSystemMails.AddAsync(Mail);
            await _context.SaveChangesAsync();
            return Mail;
        }

        public async Task<bool> DeleteEmailSistema(DateTime SsmSentDatetime)
        {
            QvSysSsmSystemMail Mail = await SearchEmailSistema(SsmSentDatetime) ?? throw new Exception("Email para exclusão não encontrado (DeleteEmailSistema)");
            _context.QvSysSsmSystemMails.Remove(Mail);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<QvSysSsmSystemMail>> ListarEmailSistema()
        {
            var retorno = await _context.QvSysSsmSystemMails.ToListAsync();
            return retorno;
        }

        public async Task<QvSysSsmSystemMail> SearchEmailSistema(DateTime SsmSentDatetime)
        {
            return await _context.QvSysSsmSystemMails.FirstOrDefaultAsync(x => x.SsmSentDatetime == SsmSentDatetime); 
        }

        public async Task<QvSysSsmSystemMail> UpdateEmailSistema(QvSysSsmSystemMail Mail, DateTime SsmSentDatetime)
        {
            QvSysSsmSystemMail ssmMail = await SearchEmailSistema(SsmSentDatetime) ?? throw new Exception("Email para atualização não encontrado (UpdateEmailSistema)");
            ssmMail.SsmMessage = Mail.SsmMessage;
            ssmMail.SsmSentDatetime = Mail.SsmSentDatetime;
            ssmMail.SsmSubject = Mail.SsmSubject;
            ssmMail.SsmUsername = Mail.SsmUsername;

            _context.QvSysSsmSystemMails.Update(ssmMail);
            await _context.SaveChangesAsync();

            return ssmMail;
        }
    }
}
