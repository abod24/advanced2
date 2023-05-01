using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    internal class Delete
    {
        public void DeleteStudent(Student student)
        {
            var context = new ApplecationDbContext();
            var target = context.Students.Find(student.Id);
            if (target != null)
            {
                context.Students.Remove(target);
                context.SaveChanges();
            }
        }
        public void DeleteSubject(Subject subject)
        {
            var context =new ApplecationDbContext();
            var target = context.subjects.Find(subject.Id);
            if (target != null)
            {
                context.subjects.Remove(target);
                context.SaveChanges();
            }
        }
        public void DeleteSubjectLecture(SubjectLectur subjectLectur)
        {
            var context = new ApplecationDbContext();
            var target = context.subjectLecturs.Find(subjectLectur.Id);
            if (target != null)
            {
                context.subjectLecturs.Remove(target);
                context.SaveChanges();
            }
        }
        public void DeleteDepartment(Department department)
        {
            var context = new ApplecationDbContext();
            var target = context.Departments.Find(department.Id);
            if (target != null)
            {
                context.Departments.Remove(target);
                context.SaveChanges();
            }
        }
        public void DeleteExam(Exam exam)
        {
            var context = new ApplecationDbContext();
            var target = context.Exams.Find(exam.Id);
            if (target != null)
            {
                context.Exams.Remove(target);
                context.SaveChanges();
            }
        }
        public void DeleteMark(StudentMark studentMark)
        {
            var context = new ApplecationDbContext();
            var target = context.StudentsMarks.Find(studentMark.Id);
            if (target != null)
            {
                context.StudentsMarks.Remove(target);
                context.SaveChanges();
            }
        }
    }
}
