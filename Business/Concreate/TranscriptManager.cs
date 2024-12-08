using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concreate;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    // Bu servisleri yazma amacımız iş kurallarını belirtebilmek!
    public class TranscriptManager : ITranscriptService
    {
        private ITranscriptRepository _transcriptRepository;
        public TranscriptManager()
        {
            _transcriptRepository = new TranscriptRepository();
        }
        public Transcript CreateTranscript(Transcript transcript)
        {
            return _transcriptRepository.CreateTranscript(transcript);
        }

        public void DeleteTranscript(int id)
        {
            _transcriptRepository.DeleteTranscript(id);
        }

        public Transcript GetTranscriptById(int id)
        {
            if (id > 0)
            {
                return _transcriptRepository.GetTranscriptById(id);
            }
            throw new Exception("id 0'dan küçük olamaz");
        }

        public List<Transcript> GetAllTranscripts()
        {
            return _transcriptRepository.GetAllTranscript();
        }

        public Transcript UpdateTranscript(Transcript transcript)
        {
            return _transcriptRepository.UpdateTranscript(transcript);
        }
    }
}
