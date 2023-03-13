using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using oraclebam.Models;
using oraclebam.Repository.Interface;

namespace oraclebam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MvSysSefExchangeFileController : ControllerBase
    {
        private readonly IMvSysSefExchangeFileRepository _mvSysSefExchangeFileRepository;
        public MvSysSefExchangeFileController(IMvSysSefExchangeFileRepository mvSysSefExchangeFileRepository)
        {
            _mvSysSefExchangeFileRepository = mvSysSefExchangeFileRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<MvSysSefExchangeFile>>> ListarExchangeFile()
        {
            List<MvSysSefExchangeFile> Lista = await _mvSysSefExchangeFileRepository.ListarExchangeFile();
            return Ok(Lista);
        }

        [HttpGet("search/{SefID}")]
        public async Task<ActionResult<MvSysSefExchangeFile>> SearchExchangeFile(long SefID)
        {
            MvSysSefExchangeFile exchangeFile = await _mvSysSefExchangeFileRepository.SearchExchangeFile(SefID);
            return Ok(exchangeFile);
        }

        [HttpPost("post")]
        public async Task<ActionResult<MvSysSefExchangeFile>> AddExchangeFile(MvSysSefExchangeFile exchangeFile)
        {
           MvSysSefExchangeFile File = await _mvSysSefExchangeFileRepository.AddExchangeFile(exchangeFile);
            return Ok(File);
        }

        [HttpPut("update")]
        public async Task<ActionResult<MvSysSefExchangeFile>> UpdateExchangeFile([FromBody] MvSysSefExchangeFile exchangeFile, long SefID)
        {
            exchangeFile.SefId = SefID;
            MvSysSefExchangeFile UpdateExchange = await _mvSysSefExchangeFileRepository.UpdateExchangeFile(exchangeFile, SefID);
            return Ok(UpdateExchange);
        }

        [HttpDelete("delete")]
        public async Task<ActionResult<MvSysSefExchangeFile>> DeleteExchangeFile(long SefID)
        {
            bool saida = await _mvSysSefExchangeFileRepository.DeleteExchangeFile(SefID);
            return Ok(saida);
        }
    }
}
