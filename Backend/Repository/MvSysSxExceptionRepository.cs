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

        public async Task<MvSysSxException> AddException(MvSysSxException Exception)
        {
            await _Context.MvSysSxExceptions.AddAsync(Exception);
            await _Context.SaveChangesAsync();
            return Exception;
        }
        public async Task<MvSysSxException> UpdateByException(MvSysSxException Exception, string sxCompany)
        {
            MvSysSxException mvException = await SearchByException(sxCompany) ?? throw new Exception("company da excessão não encontrada");
            mvException.SxColumn = Exception.SxColumn;
            mvException.SxCompany = Exception.SxCompany;
            mvException.SxComparison = Exception.SxComparison;
            mvException.SxDatetimeAltered = Exception.SxDatetimeAltered;
            mvException.SxDatetimeCreated = Exception.SxDatetimeCreated;
            mvException.SxDescription = Exception.SxDescription;
            mvException.SxModule = Exception.SxModule;
            mvException.SxNote = Exception.SxNote;
            mvException.SxTable = Exception.SxTable;
            mvException.SxUserAltered = Exception.SxUserAltered;
            mvException.SxUserCreated = Exception.SxUserCreated;
            mvException.SxValue = Exception.SxValue;

            _Context.MvSysSxExceptions.Update(mvException);
            await _Context.SaveChangesAsync();
            return mvException;

        }
        public async Task<bool> DeleteByException(string sxCompany)
        {
            MvSysSxException exception = await SearchByException(sxCompany) ?? throw new Exception("company da excessão não encontrada");
            _Context.MvSysSxExceptions.Remove(exception);
            await _Context.SaveChangesAsync();
            return true;
        }
    }
}
