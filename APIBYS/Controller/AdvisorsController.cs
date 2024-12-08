using Business.Abstract;
using Business.Concreate;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIBYS.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvisorsController : ControllerBase
    {
        private IAdvisorService _advisorService;
        public AdvisorsController()
        {
            _advisorService = new AdvisorManager();
        }
        [HttpGet]
        public List<Advisor> Get()
        {
            return _advisorService.GetAllAdvisors();
        }

        [HttpGet("{id}")]
        public Advisor Get(int id)
        {
            return _advisorService.GetAdvisorById(id);
        }
        [HttpPost]
        public Advisor Post([FromBody] Advisor advisor)
        {
            return _advisorService.CreateAdvisor(advisor);
        }
        [HttpPut]
        public Advisor put([FromBody] Advisor advisor)
        {
            return _advisorService.UpdateAdvisor(advisor);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _advisorService.DeleteAdvisor(id);
        }
    }
}
