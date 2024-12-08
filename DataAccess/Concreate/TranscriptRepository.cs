using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate
{
    public class TranscriptRepository : ITranscriptRepository
    {
        public Transcript CreateTranscript(Transcript transcript)
        {
            using (var transcriptDbContext = new ProjeDbContext())
            {
                transcriptDbContext.Transcripts.Add(transcript);
                transcriptDbContext.SaveChanges();
                return transcript;
            }
        }

        public void DeleteTranscript(int id)
        {
            using (var transcriptDbContext = new ProjeDbContext())
            {
                var deletedTranscript = GetTranscriptById(id);
                transcriptDbContext.Transcripts.Remove(deletedTranscript);
                transcriptDbContext.SaveChanges();
            }
        }

        public Transcript GetTranscriptById(int id)
        {
            using (var transcriptDbContext = new ProjeDbContext())
            {
                return transcriptDbContext.Transcripts.Find(id);
            }
        }

        public List<Transcript> GetAllTranscript()
        {
            using (var transcriptDbContext = new ProjeDbContext())
            {
                return transcriptDbContext.Transcripts.ToList();
            }
        }

        public Transcript UpdateTranscript(Transcript transcript)
        {
            using (var transcriptDbContext = new ProjeDbContext())
            {
                transcriptDbContext.Transcripts.Update(transcript);
                transcriptDbContext.SaveChanges();
                return transcript;
            }
        }
    }
}
