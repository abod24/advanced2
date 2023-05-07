using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    internal class ADD
    {
        public static void AddStudent(Student student)
        {
             var Context=new ApplecationDbContext();
             Context.Students!.Add(student);
             Context.SaveChanges();
        }
        public static void AddSubject(Subject subject)
        {
            var Context = new ApplecationDbContext();
            Context.subjects!.Add(subject);
            Context.SaveChanges();
        }
        public static void AddSubjectLectur(SubjectLectur subjectLectur)
        {
            var Context = new ApplecationDbContext();
            Context.subjectLecturs!.Add(subjectLectur);
            Context.SaveChanges();
        }
        public static void AddExams(Exam exam)
        {
            var Context = new ApplecationDbContext();
            Context.Exams!.Add(exam);
            Context.SaveChanges();
        }
        public static void AddDepartment(Department department)
        {
            var Context = new ApplecationDbContext();
            Context.Departments!.Add(department);
            Context.SaveChanges();
        }
        public static void AddStudentMark(StudentMark studentMark)
        {
            var Context = new ApplecationDbContext();
            Context.StudentsMarks!.Add(studentMark);
            Context.SaveChanges();
        }
    }
}
