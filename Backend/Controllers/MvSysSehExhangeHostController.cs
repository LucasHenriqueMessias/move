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
    }
}
