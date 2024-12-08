using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseService
    {
        List<Course> GetAllCourses();
        Course GetCoursesById(int id);
        Course CreateCourses(Course Course);
        Course UpdateCourse(Course Course);
        void DeleteCourse(int id);
    }
}
