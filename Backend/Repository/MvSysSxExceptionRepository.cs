using Microsoft.EntityFrameworkCore;
using oraclebam.Models;
using oraclebam.Repository.Interface;

namespace oraclebam.Repository
{
    public class MvSysSxExceptionRepository : IMvSysSxExceptionRepository
    {
        private readonly ModelContext _Context;

        public MvSysSxExceptionRepository(ModelContext context)
        {
            _Context = context;
        }

        public async Task<List<MvSysSxException>> ExceptionAPI()
        {
            var retorno = await _Context.MvSysSxExceptions.ToListAsync();
            return retorno;
        }

        public async Task<MvSysSxException> SearchByException(string sxCompany)
        {
            return await _Context.MvSysSxExceptions.FirstOrDefaultAsync(x => x.SxCompany == sxCompany);
        }
    }
}
