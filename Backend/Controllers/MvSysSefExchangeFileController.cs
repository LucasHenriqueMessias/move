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
    }
}
