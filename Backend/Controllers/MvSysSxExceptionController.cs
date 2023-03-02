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

        [HttpGet ("search/{sxCompany}")]
        public async Task<ActionResult<MvSysSxException>> SearchByException(string sxCompany)
        {
            MvSysSxException Lista = await _repository.SearchByException(sxCompany);
            return Ok(Lista);
        }

        [HttpPost]
        public async Task<ActionResult<MvSysSxException>> AddException([FromBody] MvSysSxException Exception)
        {
            MvSysSxException Lista = await _repository.AddException(Exception);
            return Ok(Lista);
        }

        [HttpPut("company/exception/{sxCompany}")]
        public async Task<ActionResult<MvSysSxException>> UpdateByException([FromBody] MvSysSxException Exception, string sxCompany)
        {
            Exception.SxCompany = sxCompany;
            MvSysSxException Lista = await _repository.UpdateByException(Exception, sxCompany);
            return Ok(Lista);
        }

        [HttpDelete]
        public async Task<ActionResult<MvSysSxException>> DeleteByException(string sxCompany)
        {
            bool Lista = await _repository.DeleteByException(sxCompany);
            return Ok(Lista);
        }
    }
}
