using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using oraclebam.Models;
using oraclebam.Repository;
using oraclebam.Repository.Interface;

namespace oraclebam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QvSysSelExchangeLogController : ControllerBase
    {
        private readonly IQvSysSelExchangeLogRepository _qvSysSelExchangeLogRepository;
        public QvSysSelExchangeLogController(IQvSysSelExchangeLogRepository qvSysSelExchangeLogRepository)
        {
            _qvSysSelExchangeLogRepository = qvSysSelExchangeLogRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<QvSysSelExchangeLog>>> ListarExchangeFileLog()
        {
            List<QvSysSelExchangeLog> Lista = await _qvSysSelExchangeLogRepository.ListarExchangeLog();
            return Ok(Lista);
        }
    }
}
