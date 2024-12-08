using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    // This service handles business rules for student course selection operations
    public class StudentCourseSelectionManager : IStudentCourseSelectionService
    {
        private IStudentCourseSelectionRepository _studentCourseSelectionRepository;

        public StudentCourseSelectionManager()
        {
            _studentCourseSelectionRepository = new StudentCourseSelectionRepository();
        }

        public StudentCourseSelection CreateStudentCourseSelection(StudentCourseSelection studentCourseSelection)
        {
            return _studentCourseSelectionRepository.CreateStudentCourseSelection(studentCourseSelection);
        }

        public void DeleteStudentCourseSelection(int id)
        {
            _studentCourseSelectionRepository.DeleteStudentCourseSelection(id);
        }

        public StudentCourseSelection GetStudentCourseSelectionById(int id)
        {
            if (id > 0)
            {
                return _studentCourseSelectionRepository.GetStudentCourseSelectionById(id);
            }
            throw new Exception("ID cannot be less than or equal to 0.");
        }

        public List<StudentCourseSelection> GetAllStudentCourseSelections()
        {
            return _studentCourseSelectionRepository.GetAllStudentCourseSelections();
        }

        public StudentCourseSelection UpdateStudentCourseSelection(StudentCourseSelection studentCourseSelection)
        {
            return _studentCourseSelectionRepository.UpdateStudentCourseSelection(studentCourseSelection);
        }
    }
}
