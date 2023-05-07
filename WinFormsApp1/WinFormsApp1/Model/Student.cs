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

        public string? LastName { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Phone { get; set; }
        public int RegisterDate { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;
        public ICollection<StudentMark> studentMarks { get; }=new List<StudentMark>();
    }
}
