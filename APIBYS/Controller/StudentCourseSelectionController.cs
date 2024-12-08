using Business.Abstract;
using Business.Concreate;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIBYS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentCourseSelectionsController : ControllerBase
    {
        private IStudentCourseSelectionService _studentCourseSelectionService;

        public StudentCourseSelectionsController()
        {
            _studentCourseSelectionService = new StudentCourseSelectionManager(); // Assuming this implements IStudentCourseSelectionService
        }

        [HttpGet]
        public List<StudentCourseSelection> Get()
        {
            return _studentCourseSelectionService.GetAllStudentCourseSelections();
        }

        [HttpGet("{id}")]
        public StudentCourseSelection Get(int id)
        {
            return _studentCourseSelectionService.GetStudentCourseSelectionById(id);
        }

        [HttpPost]
        public StudentCourseSelection Post([FromBody] StudentCourseSelection studentCourseSelection)
        {
            return _studentCourseSelectionService.CreateStudentCourseSelection(studentCourseSelection);
        }

        [HttpPut]
        public StudentCourseSelection Put([FromBody] StudentCourseSelection studentCourseSelection)
        {
            return _studentCourseSelectionService.UpdateStudentCourseSelection(studentCourseSelection);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _studentCourseSelectionService.DeleteStudentCourseSelection(id);
        }
    }
}
