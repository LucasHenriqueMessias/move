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

        [HttpGet("{segGroupName}")]
        public async Task<ActionResult<MvSysSegEmailGroup>> SearchByGroupEmail(string segGroupName)
        {
            MvSysSegEmailGroup EmailSearch = await _repository.SearchByGroupEmail(segGroupName);
            return Ok(EmailSearch);
        }

        [HttpPost]
        public async Task<ActionResult<MvSysSegEmailGroup>> AddEmail([FromBody] MvSysSegEmailGroup emailGroup)
        {
            MvSysSegEmailGroup EmailSearch = await _repository.AddEmail(emailGroup);
            return Ok(EmailSearch);
        }

        [HttpPut("{segGroupName}")]
        public async Task<ActionResult<MvSysSegEmailGroup>> UpdateEmail([FromBody] MvSysSegEmailGroup emailGroup, string segGroupName)
        {
            emailGroup.SegGroupName = segGroupName;
            MvSysSegEmailGroup UpdateEmail = await _repository.UpdateEmail(emailGroup, segGroupName);
            return Ok(UpdateEmail);
        }

        [HttpDelete("{segGroupName}")]
        public async Task<ActionResult<MvSysSegEmailGroup>> DeleteEmail(string segGroupName)
        {
            bool saida = await _repository.DeleteEmail(segGroupName);
            return Ok(saida);
        }
    }
}
