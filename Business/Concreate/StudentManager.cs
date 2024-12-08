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
    public class StudentManager : IStudentService
    {
        private IStudentRepository _studentRepository;
        public StudentManager()
        {
            _studentRepository = new StudentRepository();
        }
        public Student CreateStudent(Student student)
        {
            return _studentRepository.CreateStudent(student);
        }

        public void DeleteStudent(int id)
        {
            _studentRepository.DeleteStudent(id);
        }

        public Student GetStudentById(int id)
        {
            if (id > 0)
            {
                return _studentRepository.GetStudentById(id);
            }
            throw new Exception("id 0 dan kücük olamaz");
        }

        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetAllStudents();
        }

        public Student UpdateStudent(Student student)
        {
            return _studentRepository.UpdateStudent(student);
        }
    }
}
