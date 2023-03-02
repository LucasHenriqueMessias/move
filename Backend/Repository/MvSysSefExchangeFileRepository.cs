using Microsoft.EntityFrameworkCore;
using oraclebam.Models;
using oraclebam.Repository.Interface;

namespace oraclebam.Repository
{
    public class MvSysSefExchangeFileRepository : IMvSysSefExchangeFileRepository
    {
        private readonly ModelContext _dbContext;
        public MvSysSefExchangeFileRepository(ModelContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<MvSysSefExchangeFile>> ListarExchangeFile()
        {
           var retorno = await _dbContext.MvSysSefExchangeFiles.ToListAsync();
            return retorno;
        }

        public async Task<MvSysSefExchangeFile> AddExchangeFile(MvSysSefExchangeFile ExchangeFile)
        {
            await _dbContext.MvSysSefExchangeFiles.AddAsync(ExchangeFile);
            await _dbContext.SaveChangesAsync(); 
            return ExchangeFile;
        }

        public async Task<MvSysSefExchangeFile> UpdateExchangeFile(MvSysSefExchangeFile exchangeFile, long SefID)
        {
            MvSysSefExchangeFile mvSysSefExchangeFileID = await SearchExchangeFile(SefID);

            if(mvSysSefExchangeFileID == null)
            {
                throw new Exception("ID não encontrado");
            }
            else
            {
                mvSysSefExchangeFileID.SefAppend = exchangeFile.SefAppend;
                mvSysSefExchangeFileID.SefDestDir = exchangeFile.SefDestDir;
                mvSysSefExchangeFileID.SefSourceDir = exchangeFile.SefSourceDir;
                mvSysSefExchangeFileID.SefDeleteSource = exchangeFile.SefDeleteSource;
                mvSysSefExchangeFileID.SefBackupDir = exchangeFile.SefBackupDir;
                mvSysSefExchangeFileID.SefSourceFile= exchangeFile.SefSourceFile;
                mvSysSefExchangeFileID.SefCompany = exchangeFile.SefCompany;
                mvSysSefExchangeFileID.SefDateAlt = exchangeFile.SefDateAlt;
                mvSysSefExchangeFileID.SefDestFile= exchangeFile.SefDestFile;
                mvSysSefExchangeFileID.SefDestFtpUser= exchangeFile.SefDestFtpUser;
                mvSysSefExchangeFileID.SefDestHost = exchangeFile.SefDestHost;
                mvSysSefExchangeFileID.SefDestShare= exchangeFile.SefDestShare;
                mvSysSefExchangeFileID.SefId= exchangeFile.SefId;
                mvSysSefExchangeFileID.SefModule= exchangeFile.SefModule;
                mvSysSefExchangeFileID.SefOperation = exchangeFile.SefOperation;
                mvSysSefExchangeFileID.SefShare = exchangeFile.SefShare;
                mvSysSefExchangeFileID.SefSourceFile= exchangeFile.SefSourceFile;
                mvSysSefExchangeFileID.SefSourceHost= exchangeFile.SefSourceHost;
                mvSysSefExchangeFileID.SefUserAlt= exchangeFile.SefUserAlt;

                _dbContext.MvSysSefExchangeFiles.Update(mvSysSefExchangeFileID);
                await _dbContext.SaveChangesAsync();

                return mvSysSefExchangeFileID;
                }
        }

        public async Task<bool> DeleteExchangeFile(long SefID)
        {
            MvSysSefExchangeFile mvSysSefExchangeFileID = await SearchExchangeFile(SefID) ?? throw new Exception("ID para exclusão não encontrado");
            _dbContext.MvSysSefExchangeFiles.Remove(mvSysSefExchangeFileID);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<MvSysSefExchangeFile> SearchExchangeFile(long SefID)
        {
            return await _dbContext.MvSysSefExchangeFiles.FirstOrDefaultAsync(x => x.SefId == SefID);
        }
    }
}
