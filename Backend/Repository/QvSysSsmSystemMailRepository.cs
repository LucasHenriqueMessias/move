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

        public async Task<List<QvSysSsmSystemMail>> ListarEmailSistema()
        {
            var retorno = await _context.QvSysSsmSystemMails.ToListAsync();
            return retorno;
        }
    }
}
