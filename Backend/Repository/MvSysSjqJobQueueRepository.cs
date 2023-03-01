using Microsoft.EntityFrameworkCore;
using oraclebam.Models;
using oraclebam.Repository.Interface;

namespace oraclebam.Repository
{
    public class MvSysSjqJobQueueRepository : IMvSysSjqJobQueueRepository
    {
        private readonly ModelContext _context;

        public MvSysSjqJobQueueRepository(ModelContext context)
        {
            _context = context;
        }

        public async Task<List<MvSysSjqJobQueue>> AddQueue(MvSysSjqJobQueue q)
        {
            await _context.MvSysSjqJobQueues.AddAsync(q);
            await _context.SaveChangesAsync();
            return q;
        }

        public async Task<List<MvSysSjqJobQueue>> APIJobQueues()
        {
            var retorno = await _context.MvSysSjqJobQueues.ToListAsync();
            return retorno;
        }

        public async Task<bool> DeleteQueue(string SjqProcedureName)
        {
            MvSysSjqJobQueue ProcName = await SearchByProcedureName(SjqProcedureName) ?? throw new Exception("Nome da Procedure não encontrada para excluir");
            _context.MvSysSjqJobQueues.Remove(ProcName);
            await _context.SaveChangesAsync() ;
            return true;
        }

        public async Task<MvSysSjqJobQueue> SearchByProcedureName(string SjqProcedureName)
        {
            return await _context.MvSysSjqJobQueues.FirstOrDefaultAsync(x => x.SjqProcedureName == SjqProcedureName);
        }

        public async Task<List<MvSysSjqJobQueue>> UpdateQueue(MvSysSjqJobQueue q, string SjqProcedureName)
        {
            MvSysSjqJobQueue ProcName = await SearchByProcedureName(SjqProcedureName) ?? throw new Exception("Nome da Procedure não encontrada para excluir");
            ProcName.SjqStatus = q.SjqStatus;
            ProcName.SjqSaturday = q.SjqSaturday;
            ProcName.SjqInterval = q.SjqInterval;
            ProcName.SjqUserUpdated = q.SjqUserUpdated;
            ProcName.SjqUserCreated = q.SjqUserCreated;
            ProcName.SjqCurrentIteration = q.SjqCurrentIteration;
            ProcName.SjDescription = q.SjDescription;
            ProcName.SjqDatetimeCreated = q.SjqDatetimeCreated;
            ProcName.SjqDatetimeScheduled = q.SjqDatetimeScheduled;
            ProcName.SjqDatetimeUpdated = q.SjqDatetimeUpdated;
            ProcName.SjqFollowedByMail = q.SjqFollowedByMail;
            ProcName.SjqFriday = q.SjqFriday;
            ProcName.SjqMessage = q.SjqMessage;
            ProcName.SjqMonday = q.SjqMonday;
            ProcName.SjqProcedureName = q.SjqProcedureName;
            ProcName.SjqSunday = q.SjqSunday;
            ProcName.SjqThursday = q.SjqThursday;
            ProcName.SjqTotalIteration = q.SjqTotalIteration;
            ProcName.SjqWednesday = q.SjqWednesday;
            ProcName.SjqTuesday = q.SjqTuesday;
            ProcName.SjqJob = q.SjqJob;

            _context.MvSysSjqJobQueues.Update(ProcName);
            return ProcName;
        }
    }
}
