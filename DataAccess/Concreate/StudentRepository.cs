using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class StudentRepository : IStudentRepository
    {
        public Student CreateStudent(Student student)
        {
            using (var studentDbContext = new ProjeDbContext())
            {
                studentDbContext.Students.Add(student);
                studentDbContext.SaveChanges();
                return student;
            }
        }

        public void DeleteStudent(int id)
        {
            using (var studentDbContext = new ProjeDbContext())
            {
                var deletedStudent = GetStudentById(id);
                studentDbContext.Students.Remove(deletedStudent);
                studentDbContext.SaveChanges();
            }
        }

        public Student GetStudentById(int id)
        {
            using (var studentDbContext = new ProjeDbContext())
            {
                return studentDbContext.Students.Find(id);
            }
        }

        public List<Student> GetAllStudents()
        {
            using (var studentDbContext = new ProjeDbContext())
            {
                return studentDbContext.Students.ToList();
            }
        }

        public Student UpdateStudent(Student student)
        {
            using (var studentDbContext = new ProjeDbContext())
            {
                studentDbContext.Students.Update(student);
                studentDbContext.SaveChanges();
                return student;
            }
        }
    }
}
