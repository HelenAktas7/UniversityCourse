using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProjeDbContext : DbContext //DbContextten miras alıyor
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=HELEN\\SQLEXPRESS04;Database=Bys;Trusted_Connection=True;");
        }
        public DbSet<Advisor> Advisors { get; set; }
        public required DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourseSelection> StudentCourseSelections { get; set; }
        public DbSet<Transcript> transcripts { get; set; }
        public DbSet<User> Users { get; set; }
        public object Transcripts { get; internal set; }
    }
}
