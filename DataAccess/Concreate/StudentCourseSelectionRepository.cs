using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class StudentCourseSelectionRepository : IStudentCourseSelectionRepository
    {
        public StudentCourseSelection CreateStudentCourseSelection(StudentCourseSelection studentCourseSelection)
        {
            using (var dbContext = new ProjeDbContext())
            {
                dbContext.StudentCourseSelections.Add(studentCourseSelection);
                dbContext.SaveChanges();
                return studentCourseSelection;
            }
        }

        public void DeleteStudentCourseSelection(int id)
        {
            using (var dbContext = new ProjeDbContext())
            {
                var studentCourseSelection = GetStudentCourseSelectionById(id);
                dbContext.StudentCourseSelections.Remove(studentCourseSelection);
                dbContext.SaveChanges();
            }
        }

        public StudentCourseSelection GetStudentCourseSelectionById(int id)
        {
            using (var dbContext = new ProjeDbContext())
            {
                return dbContext.StudentCourseSelections.Find(id);
            }
        }

        public List<StudentCourseSelection> GetAllStudentCourseSelections()
        {
            using (var dbContext = new ProjeDbContext())
            {
                return dbContext.StudentCourseSelections.ToList();
            }
        }

        public StudentCourseSelection UpdateStudentCourseSelection(StudentCourseSelection studentCourseSelection)
        {
            using (var dbContext = new ProjeDbContext())
            {
                dbContext.StudentCourseSelections.Update(studentCourseSelection);
                dbContext.SaveChanges();
                return studentCourseSelection;
            }
        }
    }
}

