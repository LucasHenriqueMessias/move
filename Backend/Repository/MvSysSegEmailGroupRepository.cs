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

        public async Task<List<MvSysSegEmailGroup>> AddEmail(MvSysSegEmailGroup EmailGroup)
        {
            await _dbContext.MvSysSegEmailGroups.AddAsync(EmailGroup);
            await _dbContext.SaveChangesAsync();
            return EmailGroup;
        }

        public async Task<bool> DeleteEmail(string SegGroupName)
        {
            MvSysSegEmailGroup GroupName = await SearchByGroupEmail(SegGroupName) ?? throw new Exception("Nome do grupo para exclusão não encontrada");
            _dbContext.MvSysSegEmailGroups.Remove(GroupName);
            await _dbContext.SaveChangesAsync() ;
            return true;
        }

        public async Task<List<MvSysSegEmailGroup>> ListarEmails()
        {
            var retorno = await _dbContext.MvSysSegEmailGroups.ToListAsync();
            return retorno;
        }

        public async Task<MvSysSegEmailGroup> SearchByGroupEmail(string SegGroupName)
        {
            return await _dbContext.MvSysSegEmailGroups.FirstAsync(x => x.SegGroupName == SegGroupName);
        }

        public async Task<List<MvSysSegEmailGroup>> UpdateEmail(MvSysSegEmailGroup EmailGroup, string SegGroupName)
        {
            MvSysSegEmailGroup GroupName = await SearchByGroupEmail(SegGroupName) ?? throw new Exception("Nome do email para atualização não encontrado.");
            GroupName.SegDescription = EmailGroup.SegDescription;
            GroupName.SegGroupName = EmailGroup.SegGroupName;
            GroupName.SegCompany = EmailGroup.SegCompany;

            _dbContext.MvSysSegEmailGroups.Update(GroupName);
            return GroupName;
        }
    }
}
