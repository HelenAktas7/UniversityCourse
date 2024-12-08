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
    //Bu servisleri yazma amacımız iş kurallarını belirtebilmek!
    public class AdvisorManager : IAdvisorService
    {
        private IAdvisorRepository _advisorRepository;
        public AdvisorManager()
        {
            _advisorRepository = new AdvisorRepository();
        }
        public Advisor CreateAdvisor(Advisor advisor)
        {
            return _advisorRepository.CreateAdvisor(advisor);
        }

        public void DeleteAdvisor(int id)
        {
            _advisorRepository.DeleteAdvisor(id);
        }

        public Advisor GetAdvisorById(int id)
        {
            if (id > 0)
            {
                return _advisorRepository.GetAdvisorById(id);
            }
            throw new Exception("id 0 dan kücük olamaz");

        }

        public List<Advisor> GetAllAdvisors()
        {
            return _advisorRepository.GetAllAdvisor();
        }

        public Advisor UpdateAdvisor(Advisor advisor)
        {
            return _advisorRepository.UpdateAdvisor(advisor);
        }
    }
}