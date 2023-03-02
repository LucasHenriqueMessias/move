using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using oraclebam.Models;
using oraclebam.Repository.Interface;

namespace oraclebam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QvSysSsmSystemMailController : ControllerBase
    {
        private readonly IQvSysSsmSystemMailRepository _iqvSysSsmSystemMailRepository;

        public QvSysSsmSystemMailController(IQvSysSsmSystemMailRepository iqvSysSsmSystemMailRepository)
        {
            _iqvSysSsmSystemMailRepository = iqvSysSsmSystemMailRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<QvSysSsmSystemMail>>> ListarEmailSistema()
        {
            List<QvSysSsmSystemMail> Lista = await _iqvSysSsmSystemMailRepository.ListarEmailSistema();
            return Ok(Lista);
        }

        [HttpGet("search/{SsmSentDateTime}")]
        public async Task<ActionResult<QvSysSsmSystemMail>> SearchEmailSistema(DateTime SsmSentDatetime)
        {
            QvSysSsmSystemMail Lista = await _iqvSysSsmSystemMailRepository.SearchEmailSistema(SsmSentDatetime);
            return Ok(Lista);
        }

        [HttpPost]
        public async Task<ActionResult<QvSysSsmSystemMail>> AddEmailSistema([FromBody] QvSysSsmSystemMail Mail)
        {
            QvSysSsmSystemMail Lista = await _iqvSysSsmSystemMailRepository.AddEmailSistema( Mail);
            return Ok(Lista);
        }

        [HttpPut]
        public async Task<ActionResult<QvSysSsmSystemMail>> UpdateEmailSistema([FromBody] QvSysSsmSystemMail Mail, DateTime SsmSentDatetime)
        {
            Mail.SsmSentDatetime = SsmSentDatetime;
            QvSysSsmSystemMail Lista = await _iqvSysSsmSystemMailRepository.UpdateEmailSistema(Mail, SsmSentDatetime);
            return Ok(Lista);
        }

        [HttpDelete]
        public async Task<ActionResult<QvSysSsmSystemMail>> DeleteEmailSistema(DateTime SsmSentDatetime)
        {
            bool Lista = await _iqvSysSsmSystemMailRepository.DeleteEmailSistema(SsmSentDatetime);
            return Ok(Lista);
        }
    }
}
