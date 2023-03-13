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

        [HttpGet("search/{SvxCompany}")]
        public async Task<ActionResult<MvSysSvxValueException>> SearchByValue(string SvxCompany)
        {
            MvSysSvxValueException Lista = await _repository.SearchByValue(SvxCompany);
            return Ok(Lista);
        }

        [HttpPost("post/{e}")]
        public async Task<ActionResult<MvSysSvxValueException>> AddValueException([FromBody] MvSysSvxValueException e)
        {
            MvSysSvxValueException Lista = await _repository.AddValueException(e);
            return Ok(Lista);
        }
        [HttpPut]
        public async Task<ActionResult<MvSysSvxValueException>> UpdateValueException([FromBody] MvSysSvxValueException e, string svxCompany)
        {
            e.SvxCompany = svxCompany;
            MvSysSvxValueException Lista = await _repository.UpdateValueException(e, svxCompany);
            return Ok(Lista);
        }

        [HttpDelete]
        public async Task<ActionResult<MvSysSvxValueException>> DeleteValueException(string SvxCompany)
        {
            bool Lista = await _repository.DeleteValueException(SvxCompany);
            return Ok(Lista);
        }
    }
}
