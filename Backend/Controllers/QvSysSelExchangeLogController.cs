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
        
        [HttpGet("search/{SelID}")]
        public async Task<ActionResult<QvSysSelExchangeLog>> SearchExchangeLog(long SelId)
        {
            QvSysSelExchangeLog Lista = await _qvSysSelExchangeLogRepository.SearchExchangeLog(SelId);
            return Ok(Lista);
        }

        [HttpPost]
        public async Task<ActionResult<QvSysSelExchangeLog>> AddExchangeLog([FromBody] QvSysSelExchangeLog ExchangeLog)
        {
            QvSysSelExchangeLog Lista = await _qvSysSelExchangeLogRepository.AddExchangeLog(ExchangeLog);
            return Ok(Lista);
        }


        [HttpPut]
        public async Task<ActionResult<QvSysSelExchangeLog>> UpdateExchangeLog([FromBody] QvSysSelExchangeLog exchangeLog, long SelId)
        {
            exchangeLog.SelId = SelId;
            QvSysSelExchangeLog Lista = await _qvSysSelExchangeLogRepository.UpdateExchangeLog(exchangeLog, SelId);
            return Ok(Lista);
        }

        [HttpDelete]
        public async Task<ActionResult<QvSysSelExchangeLog>> DeleteExchangeLog(long SelId)
        {
            bool Lista = await _qvSysSelExchangeLogRepository.DeleteExchangeLog(SelId);
            return Ok(Lista);
        }
    }
}
