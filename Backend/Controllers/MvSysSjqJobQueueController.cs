using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using oraclebam.Models;
using oraclebam.Repository.Interface;

namespace oraclebam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MvSysSjqJobQueueController : ControllerBase
    {
        private readonly IMvSysSjqJobQueueRepository _repository;

        public MvSysSjqJobQueueController(IMvSysSjqJobQueueRepository repository)
        {
            _repository = repository;   
        }

        [HttpGet]
        public async Task<ActionResult<List<MvSysSjqJobQueue>>> APIJobQueues()
        {
            List<MvSysSjqJobQueue> Lista = await _repository.APIJobQueues();
            return Ok(Lista);
        }
    }
}
