using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IStudentCourseSelectionRepository
    {
        List<StudentCourseSelection> GetAllStudentCourseSelections(); // Returns a list of all StudentCourseSelections

        StudentCourseSelection GetStudentCourseSelectionById(int id); // Returns a single StudentCourseSelection by ID

        StudentCourseSelection CreateStudentCourseSelection(StudentCourseSelection studentCourseSelection); // Adds a new StudentCourseSelection

        StudentCourseSelection UpdateStudentCourseSelection(StudentCourseSelection studentCourseSelection); // Updates an existing StudentCourseSelection

        void DeleteStudentCourseSelection(int id); // Deletes a StudentCourseSelection by ID
    }
}

