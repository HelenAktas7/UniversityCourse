using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICourseRepository
    {
        List<Course> GetAllCourse(); //liste türünde Course döndürecek

        Course GetCourseById(int id); //Tek bir Course döndürme

        Course CreateCourse(Course advisor); //Course Girme

        Course UpdateCourse(Course advisor); //Course Güncelleme

        void DeleteCourse(int id);  //CourseSilme
    }
}