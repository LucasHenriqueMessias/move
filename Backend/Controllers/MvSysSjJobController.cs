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

        [HttpGet("search/{ProcedureName}")]
        public async Task<ActionResult<MvSysSjJob>> Searchjob(string ProcedureName)
        {
            MvSysSjJob Lista = await _repository.SearchJob(ProcedureName);
            return Ok(Lista);
        }

        [HttpPost]
        public async Task<ActionResult<MvSysSjJob>> Addjob([FromBody] MvSysSjJob job)
        {
            MvSysSjJob Lista = await _repository.AddJob(job);
            return Ok(Lista);
        }

        [HttpPut("update/{ProcedureName}")]
        public async Task<ActionResult<MvSysSjJob>> Updatejob([FromBody] MvSysSjJob job, string ProcedureName)
        {
            job.SjProcedureName = ProcedureName;
            MvSysSjJob Lista = await _repository.UpdateJob(job, ProcedureName);
            return Ok(Lista);
        }
        [HttpDelete]
        public async Task<ActionResult<MvSysSjJob>> Deletejob(string ProcedureName)
        {
            bool Lista = await _repository.DeleteJob(ProcedureName);
            return Ok(Lista);
        }
    }
}
