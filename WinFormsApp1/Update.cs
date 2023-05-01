using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    internal class Update
    {
        public void UpdateStudent(Student student)
        {
            var context=new ApplecationDbContext();
            var newstudent = context.Students.Find(student.Id);
            if (newstudent != null)
            {
                newstudent.Username = student.Username;
                newstudent.FirstName = student.FirstName;
                newstudent.LastName = student.LastName;
                newstudent.Email = student.Email;
                newstudent.DepartmentId = student.DepartmentId;
                newstudent.RegisterDate = student.RegisterDate;
                context.Students.Add(newstudent);
                context.SaveChanges();
            }
            
        }
        public void UpdateSubject(Subject subject)
        {
            var context = new ApplecationDbContext();
            var newsubject = context.subjects.Find(subject.Id);
            if (newsubject != null)
            {
                newsubject.DepartmentId=subject.DepartmentId;
                newsubject.Name = subject.Name;
                newsubject.MinimumDgree = subject.MinimumDgree;
                newsubject.Term = subject.Term;
                newsubject.Year = subject.Year;
                context.subjects.Add(newsubject);
                context.SaveChanges();
            }

        }
        public void UpdateSubjectLectur(SubjectLectur subjectLectur)
        {
            var context = new ApplecationDbContext();
            var newsubjectlectur = context.subjectLecturs.Find(subjectLectur.Id);
            if (newsubjectlectur != null)
            {
                newsubjectlectur.SubjectId = subjectLectur.SubjectId;
                newsubjectlectur.Title = subjectLectur.Title;
                newsubjectlectur.Content = subjectLectur.Content;
                context.subjectLecturs.Add(newsubjectlectur);
                context.SaveChanges();
            }

        }
        public void UpdateDepartment(Department department)
        {
            var context = new ApplecationDbContext();
            var newdepartment = context.Departments.Find(department.Id);
            if (newdepartment != null)
            {
                newdepartment.Name = department.Name;
                context.Departments.Add(newdepartment);
                context.SaveChanges();
            }

        }
        public void UpdateExam(Exam exam)
        {
            var context = new ApplecationDbContext();
            var newexam = context.Exams.Find(exam.Id);
            if (newexam != null)
            {
                newexam.SubjectId = exam.SubjectId;
                newexam.Date = exam.Date;
                newexam.Term = exam.Term;
                context.Exams.Add(newexam);
                context.SaveChanges();
            }

        }
        public void UpdateStudentMark(StudentMark studentMark)
        {
            var context = new ApplecationDbContext();
            var newmark = context.StudentsMarks.Find(studentMark.Id);
            if (newmark != null)
            {
                newmark.StudentId = studentMark.StudentId;
                newmark.ExamId = studentMark.ExamId;
                newmark.Mark = studentMark.Mark;
                context.StudentsMarks.Add(newmark);
                context.SaveChanges();
            }
        }
    }
}
