using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate
{
    public class CourseRepository : ICourseRepository
    {
        public object CourseDbContext { get; private set; }

        public Course CreateCourse(Course Course)
        {
            using (var CourseDbContext = new ProjeDbContext())
            {
                CourseDbContext.Courses.Add(Course);
                CourseDbContext.SaveChanges();
                return Course;
            }
        }

        public void DeleteCourse(int id)
        {
            using (var CourseDbContext = new ProjeDbContext())
            {
                var deletedCourse = GetCourseById(id);
                CourseDbContext.Courses.Remove(deletedCourse);
                CourseDbContext.SaveChanges();
            }
        }

        public Advisor GetAdvisorById(int id)
        {
            using (var advisorDbContext = new ProjeDbContext())
            {
                return CourseDbContext.Courses.Find(id);
            }
        }

        public List<Advisor> GetAllAdvisor()
        {
            using (var advisorDbContext = new ProjeDbContext())
            {
                return advisorDbContext.Advisors.ToList();
            }
        }

        public List<Course> GetAllCourse()
        {
            throw new NotImplementedException();
        }

        public Course GetCourseById(int id)
        {
            throw new NotImplementedException();
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

        public Course UpdateCourse(Course advisor)
        {
            throw new NotImplementedException();
        }
    }
}