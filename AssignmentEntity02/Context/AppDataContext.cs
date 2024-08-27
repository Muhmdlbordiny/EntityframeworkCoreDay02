using AssignmentEntity02.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEntity02.Context
{
    internal class AppDataContext:DbContext
    {
        public AppDataContext():base()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        
          =>  optionsBuilder.UseSqlServer("Server=.;Database= Assigment02EFCore;Trusted_Connection =True; TrustServerCertificate = True");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseInstructor>(C =>
            {
                C.HasKey(c => new { c.Cr_Id, c.Ins_Id });
                C.Property(c => c.Ins_Id).UseIdentityColumn(10, 10);
                

            });
            modelBuilder.Entity<CourseStudent>(s =>
            {
                s.HasKey(s => new {s.Stud_Id,s.Cors_Id});
                s.Property(s => s.Stud_Id).UseIdentityColumn(100, 100);
            });
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseInstructor> courseInstructors { get; set; }
        public DbSet<CourseStudent> courseStudents {  get; set; }
        public DbSet<Topic> topics { get; set; }
    }
}
