using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    internal class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Username { get; set; }

        public string? FirstName { get; set; }

        public int LastName { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Phone { get; set; }
        public int RegisterDate { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;
        public ICollection<StudentMark> studentMarks { get; }=new List<StudentMark>();
        public void Addstudnt(Student student)
        {
            var add = new ApplecationDbContext();
            var Studentnew = new Student {
                Username = student.Username,
                FirstName = student.FirstName,
                LastName = student.LastName,
                Email = student.Email,
                Phone = student.Phone,
                RegisterDate = student.RegisterDate,
                DepartmentId = student.DepartmentId
            };
            add.Students.Add(Studentnew);
            add.SaveChanges();
        }
    }
}
