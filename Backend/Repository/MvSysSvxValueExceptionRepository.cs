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

        public async Task<MvSysSvxValueException> AddValueException(MvSysSvxValueException e)
        {
            await _context.MvSysSvxValueExceptions.AddAsync(e);
            await _context.SaveChangesAsync();
            return e;
        }

        public async Task<bool> DeleteValueException(string SvxCompany)
        {
            MvSysSvxValueException Value = await SearchByValue(SvxCompany) ?? throw new Exception("Company não encontrada");
            _context.MvSysSvxValueExceptions.Remove(Value);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<MvSysSvxValueException> SearchByValue(string svxCompany)
        {
            return await _context.MvSysSvxValueExceptions.FirstOrDefaultAsync(x => x.SvxCompany == svxCompany);
        }

        public async Task<MvSysSvxValueException> UpdateValueException(MvSysSvxValueException e, string SvxCompany)
        {
            MvSysSvxValueException Value = await SearchByValue(SvxCompany) ?? throw new Exception("Company não encontrada");

            Value.SvxActive = e.SvxActive;
            Value.SvxCompany = SvxCompany;
            Value.SvxAlphanumericValue = e.SvxAlphanumericValue;
            Value.SvxDatetimeAltered = e.SvxDatetimeAltered;
            Value.SvxDatetimeCreated = e.SvxDatetimeCreated;
            Value.SvxDatetimeValue = e.SvxDatetimeValue;
            Value.SvxNumericValue = e.SvxNumericValue;
            Value.SvxUserAltered = e.SvxUserAltered;
            Value.SvxUserCreated = e.SvxUserCreated;

            _context.MvSysSvxValueExceptions.Update(Value);
            return Value;

        }

        public async Task<List<MvSysSvxValueException>> ValueExceptionAPI()
        {
            var retorno = await _context.MvSysSvxValueExceptions.ToListAsync();
            return retorno;
        }
    }

}
