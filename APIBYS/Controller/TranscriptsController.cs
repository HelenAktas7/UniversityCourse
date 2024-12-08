using Business.Abstract;
using Business.Concreate;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIBYS.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranscriptsController : ControllerBase
    {
        private ITranscriptService _transcriptService;
        public TranscriptsController()
        {
            _transcriptService = new TranscriptManager();
        }

        [HttpGet]
        public List<Transcript> Get()
        {
            return _transcriptService.GetAllTranscripts();
        }

        [HttpGet("{id}")]
        public Transcript Get(int id)
        {
            return _transcriptService.GetTranscriptById(id);
        }

        [HttpPost]
        public Transcript Post([FromBody] Transcript transcript)
        {
            return _transcriptService.CreateTranscript(transcript);
        }

        [HttpPut]
        public Transcript Put([FromBody] Transcript transcript)
        {
            return _transcriptService.UpdateTranscript(transcript);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _transcriptService.DeleteTranscript(id);
        }
    }
}
