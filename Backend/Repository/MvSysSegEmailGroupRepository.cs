using Microsoft.EntityFrameworkCore;
using oraclebam.Models;
using oraclebam.Repository.Interface;

namespace oraclebam.Repository
{
    public class MvSysSegEmailGroupRepository : IMvSysSegEmailGroupRepository
    {
        private readonly ModelContext _dbContext;
        public MvSysSegEmailGroupRepository(ModelContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<MvSysSegEmailGroup> AddEmail(MvSysSegEmailGroup emailGroup)
        {
            await _dbContext.MvSysSegEmailGroups.AddAsync(emailGroup);
            await _dbContext.SaveChangesAsync();
            return emailGroup;
        }

        public async Task<bool> DeleteEmail(string segGroupName)
        {
            MvSysSegEmailGroup GroupName = await SearchByGroupEmail(segGroupName) ?? throw new Exception("Nome do grupo para exclusão não encontrada");
            _dbContext.MvSysSegEmailGroups.Remove(GroupName);
            await _dbContext.SaveChangesAsync() ;
            return true;
        }

        public async Task<List<MvSysSegEmailGroup>> ListarEmails()
        {
            var retorno = await _dbContext.MvSysSegEmailGroups.ToListAsync();
            return retorno;
        }

        public async Task<MvSysSegEmailGroup> SearchByGroupEmail(string segGroupName)
        {
            return await _dbContext.MvSysSegEmailGroups.FirstOrDefaultAsync(x => x.SegGroupName == segGroupName);
        }

        public async Task<MvSysSegEmailGroup> UpdateEmail(MvSysSegEmailGroup EmailGroup, string segGroupName)
        {
            MvSysSegEmailGroup GroupName = await SearchByGroupEmail(segGroupName) ?? throw new Exception("Nome do email para atualização não encontrado.");
            GroupName.SegDescription = EmailGroup.SegDescription;
            GroupName.SegGroupName = EmailGroup.SegGroupName;
            GroupName.SegCompany = EmailGroup.SegCompany;

            _dbContext.MvSysSegEmailGroups.Update(GroupName);
            return GroupName;
        }
    }
}
