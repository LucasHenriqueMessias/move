using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using oraclebam.Models;
using oraclebam.Repository.Interface;

namespace oraclebam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MvSysSvxValueExceptionController : ControllerBase
    {
        private readonly IMvSysSvxValueExceptionRepository _repository;

        public MvSysSvxValueExceptionController(IMvSysSvxValueExceptionRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<List<MvSysSvxValueException>>> ValueExceptionAPI()
        {
            List<MvSysSvxValueException> Lista = await _repository.ValueExceptionAPI();
            return Ok(Lista);
        }
    }
}
