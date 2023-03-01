using Microsoft.EntityFrameworkCore;
using oraclebam.Models;
using oraclebam.Repository.Interface;

namespace oraclebam.Repository
{
    public class MvSysSjJobRepository : IMvSysSjJobRepository
    {
        private readonly ModelContext _context;

        public MvSysSjJobRepository(ModelContext context)
        {
            _context = context;
        }

        public async Task<List<MvSysSjJob>> AddJob(MvSysSjJob Sjob)
        {
            await _context.MvSysSjJobs.AddAsync(Sjob);
            await _context.SaveChangesAsync();
            return Sjob;
        }

        public async Task<List<MvSysSjJob>> APISjJob()
        {
            var retorno = await _context.MvSysSjJobs.ToListAsync();
            return retorno;
        }


        public async Task<List<MvSysSjJob>> SearchJob(string ProcedureName)
        {
            //erro na linha
            return await _context.MvSysSjJobs.FirstOrDefaultAsync(x => x.SjProcedureName == ProcedureName);
        }

        public Task<List<MvSysSjJob>> UpdateJob(MvSysSjJob job, string ProcedureName)
        {
            throw new NotImplementedException();
        }

       public async Task<bool> DeleteJob(string ProcedureName)
        {
            MvSysSjJob SjJob = await SearchJob(ProcedureName);

            if (SjJob != null)
            {
                throw new Exception("Nome da Procedure não encontrado para exclusão");
            }

            _context.MvSysSjJobs.Remove(SjJob);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
