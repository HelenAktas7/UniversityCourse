using Business.Abstract;
using Business.Concreate;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIBYS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private IStudentService _studentService;

        public StudentsController()
        {
            _studentService = new StudentManager(); // Assuming StudentManager implements IStudentService
        }

        [HttpGet]
        public List<Student> Get()
        {
            return _studentService.GetAllStudents();
        }

        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return _studentService.GetStudentById(id);
        }

        [HttpPost]
        public Student Post([FromBody] Student student)
        {
            return _studentService.CreateStudent(student);
        }

        [HttpPut]
        public Student Put([FromBody] Student student)
        {
            return _studentService.UpdateStudent(student);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _studentService.DeleteStudent(id);
        }
    }
}
