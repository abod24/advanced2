using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    internal class Subject
    {
        [Key]
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;
        public string? Name { get; set; }
        public int MinimumDgree { get; set; }
        public int Term { get; set; }
        public int Year { get; set; }
        public ICollection<SubjectLectur> subjectLecturs { get; }=new List <SubjectLectur>();
        public ICollection<Exam> exams { get; } =new List<Exam>();
    }
}
