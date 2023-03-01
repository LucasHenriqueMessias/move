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
    }
}
