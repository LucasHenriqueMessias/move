using Microsoft.AspNetCore.Mvc;
using oraclebam.Models;
using oraclebam.Repository;
using oraclebam.Repository.Interface;

namespace oraclebam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MvSysSeoExchangeOperationController : Controller
    {
        private readonly IMvSysSeoExchangeOperationRepository _controller;
        
        public MvSysSeoExchangeOperationController(IMvSysSeoExchangeOperationRepository controller)
        {
            _controller = controller;
        }
        [HttpGet]
        public async Task<ActionResult<List<MvSysSeoExchangeOperation>>> ListarExchangeOperation()
        {
            List<MvSysSeoExchangeOperation> Lista = await _controller.ListarExchangeOperation();
            return Ok(Lista);
        }

        [HttpGet("Search/{seoOperation}")]
        public async Task<ActionResult<MvSysSeoExchangeOperation>> SearchExchangeOperation(string seoOperation)
        {
            MvSysSeoExchangeOperation Lista = await _controller.SearchExchangeOperation(seoOperation);
            return Ok(Lista);
        }

        [HttpPost]
        public async Task<ActionResult<MvSysSeoExchangeOperation>> AddExchangeOperation([FromBody] MvSysSeoExchangeOperation exchangeOperation)
        {
            MvSysSeoExchangeOperation Lista = await _controller.AddExchangeOperation(exchangeOperation);
            return Ok(Lista);
        }
        [HttpPut("Update/{seoOperation}")]
        public async Task<ActionResult<MvSysSeoExchangeOperation>> UpdateExchangeOperation([FromBody] MvSysSeoExchangeOperation exchangeOperation, string seoOperation)
        {
            exchangeOperation.SeoOperation = seoOperation;
            MvSysSeoExchangeOperation Lista = await _controller.UpdateExchangeOperation(exchangeOperation, seoOperation);
            return Ok(Lista);
        }

        [HttpDelete]
        public async Task<ActionResult<MvSysSeoExchangeOperation>> DeleteExchangeOperation(string seoOperation)
        {
            bool Lista = await _controller.DeleteExchangeOperation(seoOperation);
            return Ok(Lista);
        }
    }
}
