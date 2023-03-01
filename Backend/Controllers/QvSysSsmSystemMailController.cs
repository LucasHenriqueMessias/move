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
        public async Task<List<QvSysSsmSystemMail>> ListarEmailSistema()
        {
            List<QvSysSsmSystemMail> Lista = await _iqvSysSsmSystemMailRepository.ListarEmailSistema();
            return Lista;
        }
    }
}
