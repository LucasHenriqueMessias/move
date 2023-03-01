using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using oraclebam.Models;
using oraclebam.Repository.Interface;

namespace oraclebam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MvSysSegEmailGroupController : ControllerBase
    {
        private readonly IMvSysSegEmailGroupRepository _repository;

        public MvSysSegEmailGroupController(IMvSysSegEmailGroupRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<MvSysSegEmailGroup>>> ListarEmails()
        {
            List<MvSysSegEmailGroup> Lista = await _repository.ListarEmails();
            return Ok(Lista);
        }
    }
}
