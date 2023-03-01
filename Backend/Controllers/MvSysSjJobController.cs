using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using oraclebam.Models;
using oraclebam.Repository.Interface;

namespace oraclebam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MvSysSjJobController : ControllerBase
    {
        private readonly IMvSysSjJobRepository _repository;

        public MvSysSjJobController(IMvSysSjJobRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<MvSysSjJob>>> APISjob()
        {
            List<MvSysSjJob> Lista = await _repository.APISjJob();
            return Ok(Lista);
        }
    }
}
