using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    internal class SubjectLectur
    {
        [Key]
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; } = null!;
        public string? Title { get; set; }
        public string? Content { get; set; }
    }
}
