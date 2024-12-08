using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAdvisorService
    {
        List<Advisor> GetAllAdvisors();
        Advisor GetAdvisorById(int id);
        Advisor CreateAdvisor(Advisor advisor);
        Advisor UpdateAdvisor(Advisor advisor);
        void DeleteAdvisor(int id);
    }
}
