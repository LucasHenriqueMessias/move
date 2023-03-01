using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using oraclebam.Models;
using oraclebam.Repository.Interface;

namespace oraclebam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MvSysSxExceptionController : ControllerBase
    {
        private readonly IMvSysSxExceptionRepository _repository;

        public MvSysSxExceptionController(IMvSysSxExceptionRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<MvSysSxException>>> ExceptionAPI()
        {
            List<MvSysSxException> Lista = await _repository.ExceptionAPI();
            return Ok(Lista);
        }
    }
}
