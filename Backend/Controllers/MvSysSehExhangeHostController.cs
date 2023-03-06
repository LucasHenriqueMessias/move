using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using oraclebam.Models;
using oraclebam.Repository.Interface;

namespace oraclebam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MvSysSehExhangeHostController : ControllerBase
    {
        private readonly IMvSysSehExchangeHostRepository _mvSysSehExchangeHostRepository;

        public MvSysSehExhangeHostController(IMvSysSehExchangeHostRepository mvSysSehExchangeHostRepository)
        {
            _mvSysSehExchangeHostRepository = mvSysSehExchangeHostRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<MvSysSehExchangeHost>>> ListarExchangeHost()
        {
            List<MvSysSehExchangeHost> Lista = await _mvSysSehExchangeHostRepository.ListarExchangeHost();
            return Ok(Lista);
        }

        [HttpGet("search/{sehCompany}")]
        public async Task<ActionResult<MvSysSehExchangeHost>> SearchExchangeHost(string sehCompany)
        {
            MvSysSehExchangeHost exchangeHost = await _mvSysSehExchangeHostRepository.SearchExchangeHost(sehCompany);
            return Ok(exchangeHost);
        }

        [HttpPost]
        public async Task<ActionResult<MvSysSehExchangeHost>> AddExchangeHost(MvSysSehExchangeHost exchangeHost)
        {
            MvSysSehExchangeHost sehExchangeHost = await _mvSysSehExchangeHostRepository.AddExchangeHost(exchangeHost);
            return Ok(sehExchangeHost);
        }

        [HttpPut("update/{SehCompany}")]
        public async Task<ActionResult<MvSysSehExchangeHost>> UpdateExchangeHost([FromBody] MvSysSehExchangeHost exchangeHost, string SehCompany)
        {
            exchangeHost.SehCompany = SehCompany;
            MvSysSehExchangeHost sehExchangeHost = await _mvSysSehExchangeHostRepository.UpdateExchangeHost(exchangeHost, SehCompany);
            return Ok(sehExchangeHost);
        }

        [HttpDelete]
        public async Task<ActionResult<MvSysSehExchangeHost>> DeleteExchangeHost(string SehCompany)
        {
            bool saida = await _mvSysSehExchangeHostRepository.DeleteExchangeHost(SehCompany);
            return Ok(saida);
        }
    }
}
