using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStudentCourseSelectionService
    {
        List<StudentCourseSelection> GetAllStudentCourseSelections();
        StudentCourseSelection GetStudentCourseSelectionById(int id);
        StudentCourseSelection CreateStudentCourseSelection(StudentCourseSelection studentCourseSelection);
        StudentCourseSelection UpdateStudentCourseSelection(StudentCourseSelection studentCourseSelection);
        void DeleteStudentCourseSelection(int id);
    }
}

