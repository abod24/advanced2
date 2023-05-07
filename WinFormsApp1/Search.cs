using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    internal class Search
    {
        public static Student Student(int ID)
        {
            var context = new ApplecationDbContext();
            var student = context.Students!.Find(ID);
            return student!;
        }

        public static Subject subject(int ID)
        {
            var context = new ApplecationDbContext();
            var Subject = context.subjects!.Find(ID);
            return Subject!;
        }

        public static SubjectLectur subjectLectur(int ID)
        {
            var context = new ApplecationDbContext();
            var subjectlectur = context.subjectLecturs!.Find(ID);
            return subjectlectur!;
        }

        public static Department department(int ID)
        {
            var context = new ApplecationDbContext();
            var department = context.Departments!.Find(ID);
            return department!;
        }
        public static Exam exam(int ID)
        {
            var context = new ApplecationDbContext();
            var exam = context.Exams!.Find(ID);
            return exam!;
        }

        public static StudentMark studentMark(int ID)
        {
            var context = new ApplecationDbContext();
            var mark = context.StudentsMarks!.Find(ID);
            return mark!;
        }
    }
}
