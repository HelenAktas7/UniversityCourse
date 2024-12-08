using Business.Abstract;
using Business.Concreate;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIBYS.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private ICourseService _courseService;
        public CoursesController()
        {
            _courseService = new CourseManager();
        }
        [HttpGet]
        public List<Course> Get()
        {
            return _courseService.GetAllCourses();
        }

        [HttpGet("{id}")]
        public Course Get(int id)
        {
            return _courseService.GetCoursesById(id);
        }
        [HttpPost]
        public Course Post([FromBody] Course course)
        {
            return _courseService.CreateCourses(course);
        }
        [HttpPut]
        public Course put([FromBody] Course course)
        {
            return _courseService.UpdateCourse(course);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _courseService.DeleteCourse(id);
        }
    }
}

