using Microsoft.EntityFrameworkCore;
using oraclebam.Models;
using oraclebam.Repository.Interface;

namespace oraclebam.Repository
{
    public class MvSysSvxValueExceptionRepository : IMvSysSvxValueExceptionRepository
    {
        private readonly ModelContext _context;

        public MvSysSvxValueExceptionRepository(ModelContext context)
        {
            _context = context;
        }

        public async Task<List<MvSysSvxValueException>> AddValueException(MvSysSvxValueException e)
        {
            await _context.MvSysSvxValueExceptions.AddAsync(e);
            await _context.SaveChangesAsync();
            return e;
        }

        public Task<bool> DeleteValueException(string SvxCompany)
        {
            throw new NotImplementedException();
        }

        public async Task<List<MvSysSvxValueException>> SearchByValue(string SvxCompany)
        {
            return await _context.MvSysSvxValueExceptions.FirstOrDefault(x => x.SvxCompany == SvxCompany);
        }

        public async Task<List<MvSysSvxValueException>> UpdateValueException(MvSysSvxValueException e, string SvxCompany)
        {
            MvSysSvxValueException Value = await SearchByValue(SvxCompany) ?? throw new Exception("Company não encontrada");


        }

        public async Task<List<MvSysSvxValueException>> ValueExceptionAPI()
        {
            var retorno = await _context.MvSysSvxValueExceptions.ToListAsync();
            return retorno;
        }
    }

}
