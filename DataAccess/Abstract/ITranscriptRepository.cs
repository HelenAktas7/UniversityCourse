using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ITranscriptRepository
    {
        List<Transcript> GetAllTranscript(); // Liste türünde Transcript döndürecek

        Transcript GetTranscriptById(int id); // Tek bir Transcript döndürme

        Transcript CreateTranscript(Transcript transcript); // Transcript Girme

        Transcript UpdateTranscript(Transcript transcript); // Transcript Güncelleme

        void DeleteTranscript(int id);  // Transcript Silme
    }
}
