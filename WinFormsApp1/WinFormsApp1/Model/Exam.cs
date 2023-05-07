using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    internal class Exam
    {
        [Key]
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; } = null!;
        public DateTime Date { get; set; }
        public int Term { get; set; }

        public ICollection<StudentMark> studentMarks { get; set; }=new List<StudentMark>();
      
    }
}
