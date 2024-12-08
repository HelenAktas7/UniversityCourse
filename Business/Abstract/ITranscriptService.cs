using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITranscriptService
    {
        List<Transcript> GetAllTranscripts();
        Transcript GetTranscriptById(int id);
        Transcript CreateTranscript(Transcript transcript);
        Transcript UpdateTranscript(Transcript transcript);
        void DeleteTranscript(int id);
    }
}
