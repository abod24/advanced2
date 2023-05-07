using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    internal class SelectIterm
    {
        public static List<Student> AllStudent()
        {
            var context = new ApplecationDbContext();
            var students = context.Students!.ToList();
            return students;
        }

        public static List<Subject> AllSubject()
        {
            var context = new ApplecationDbContext();
            var subject = context.subjects!.ToList();
            return subject;
        }

        public static List<SubjectLectur> AllSubjectLectur()
        {
            var context = new ApplecationDbContext();
            var subjectlectur = context.subjectLecturs!.ToList();
            return subjectlectur;
        }

        public static List<Department> AllDepartment()
        {
            var context = new ApplecationDbContext();
            var department = context.Departments!.ToList();
            return department;
        }

        public static List<Exam> AllExam()
        {
            var context = new ApplecationDbContext();
            var exam = context.Exams!.ToList();
            return exam;
        }

        public static List<StudentMark> AllMark()
        {
            var context = new ApplecationDbContext();
            var mark = context.StudentsMarks!.ToList();
            return mark;
        }

        public static List<Student> StudentInDepartment(int IDDepartment,int Season)
        {
            var context = new ApplecationDbContext();
            var student = context.Students!.Where(p => p.DepartmentId == IDDepartment).ToList();
            return student;
        }

        public static List<Student> StudentsDontAdducing(int IDExam) 
        {
            var context = new ApplecationDbContext();
            var Adducing = (from students in context.Students
                           join mark in context.StudentsMarks!
                           on students.Id equals mark.StudentId
                           where mark.ExamId == IDExam
                           && students.Id != mark.StudentId
                           select students).ToList();
            return Adducing;
        }

        public static List<Student> StudentsAdducing(int IDExam) 
        {
            var context = new ApplecationDbContext();
            var Adducing = (from students in context.Students
                            join mark in context.StudentsMarks!
                            on students.Id equals mark.StudentId
                            where mark.ExamId == IDExam
                            && students.Id == mark.StudentId
                            select students).ToList();
            return Adducing;
        }

        public static List<Subject> SubjectsOfStudent(int ID,int Year)
        {
            var context = new ApplecationDbContext();
            var listofsubject = (from students in context.Students
                                 join subject in context.subjects!
                                 on students.Id equals subject.DepartmentId
                                 where subject.DepartmentId == ID
                                 && subject.Year == Year
                                 && students.DepartmentId == subject.DepartmentId
                                 select subject).ToList();
            return listofsubject;
        }

        public static List<Subject> SubjectsOfStudent(int ID)
        {
            var context = new ApplecationDbContext();
            var listofsubject = (from students in context.Students
                                 join subject in context.subjects!
                                 on students.DepartmentId equals subject.DepartmentId
                                 where subject.DepartmentId == ID
                                 && students.DepartmentId == subject.DepartmentId
                                 select subject).ToList();
            return listofsubject;
        }

        public static int CountOfLectur(int ID)
        {
            var context = new ApplecationDbContext();
            var countoflectur = (from subject in context.subjects
                                 join subjectlectur in context.subjectLecturs!
                                 on subject.Id equals subjectlectur.SubjectId
                                 where subjectlectur.SubjectId == ID
                                 select subjectlectur).Count();
            return countoflectur;
        }

        public static int CountOfLectur(int ID,int year)
        {
            var context = new ApplecationDbContext();
            var countoflectur = (from subject in context.subjects
                                 join subjectlectur in context.subjectLecturs!
                                 on subject.Id equals subjectlectur.SubjectId
                                 where subjectlectur.SubjectId == ID
                                 && subject.Year == year
                                 select subjectlectur).Count();
            return countoflectur;
        }

    }
}
