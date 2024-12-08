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
    public class CourseManager : ICourseService
    {
        private ICourseRepository _courseRepository;
        public CourseManager()
        {
            _courseRepository = new CourseRepository();
        }
        public Course CreateCourse(Course course)
        {
            return _courseRepository.CreateCourse(course);
        }

        public void DeleteCourse(int id)
        {
            _courseRepository.DeleteCourse(id);
        }

        public Course GetCourseById(int id)
        {
            if (id > 0)
            {
                return _courseRepository.GetCourseById(id);
            }
            throw new Exception("id 0 dan kücük olamaz");

        }

        public List<Course> GetAllCourses()
        {
            return _courseRepository.GetAllCourse();
        }

        public Course UpdateCourse(Course course)
        {
            return _courseRepository.UpdateCourse(course);
        }
    }
}