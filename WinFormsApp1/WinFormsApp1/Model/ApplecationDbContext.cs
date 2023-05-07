using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    internal class ApplecationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=MyDbTcc;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Subject>? subjects { get; set; }
        public DbSet<StudentMark>? StudentsMarks { get; set; }
        public DbSet<Department>? Departments { get; set; }
        public DbSet<Exam>? Exams { get; set; }
        public DbSet<SubjectLectur>? subjectLecturs { get; set; }
    }
}
