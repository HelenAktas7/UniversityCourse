using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate
{
    public class AdvisorRepository : IAdvisorRepository
    {
        public Advisor CreateAdvisor(Advisor advisor)
        {
            using (var advisorDbContext = new ProjeDbContext())
            {
                advisorDbContext.Advisors.Add(advisor);
                advisorDbContext.SaveChanges();
                return advisor;
            }
        }

        public void DeleteAdvisor(int id)
        {
            using (var advisorDbContext = new ProjeDbContext())
            {
                var deletedAdvisor = GetAdvisorById(id);
                advisorDbContext.Advisors.Remove(deletedAdvisor);
                advisorDbContext.SaveChanges();
            }
        }

        public Advisor GetAdvisorById(int id)
        {
            using (var advisorDbContext = new ProjeDbContext())
            {
                return advisorDbContext.Advisors.Find(id);
            }
        }

        public List<Advisor> GetAllAdvisor()
        {
            using (var advisorDbContext = new ProjeDbContext())
            {
                return advisorDbContext.Advisors.ToList();
            }
        }

        public Advisor UpdateAdvisor(Advisor advisor)
        {
            using (var advisorDbContext = new ProjeDbContext())
            {
                advisorDbContext.Advisors.Update(advisor);
                advisorDbContext.SaveChanges();
                return advisor;
            }
        }
    }
}