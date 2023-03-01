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

        public async Task<MvSysSjJob> AddJob(MvSysSjJob Sjob)
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


        public async Task<MvSysSjJob> SearchJob(string ProcedureName)
        {
            return await _context.MvSysSjJobs.FirstOrDefaultAsync(x => x.SjProcedureName == ProcedureName);
        }

        public async Task<MvSysSjJob> UpdateJob(MvSysSjJob job, string ProcedureName)
        {
            MvSysSjJob sJob = await SearchJob(ProcedureName) ?? throw new Exception("Job não encontrado");

            sJob.SjProcedureName = job.SjProcedureName;
            sJob.SjUserCreated = job.SjUserCreated;
            sJob.SjUserUpdated = job.SjUserUpdated;
            sJob.SjDescription = job.SjDescription;
            sJob.SjDatetimeUpdated = job.SjDatetimeUpdated;
            sJob.SjDatetimeCreated = job.SjDatetimeCreated;

            _context.MvSysSjJobs.Update(sJob);
            return sJob;
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
