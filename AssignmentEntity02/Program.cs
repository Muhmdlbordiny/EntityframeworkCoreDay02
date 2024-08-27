using AssignmentEntity02.Context;
using AssignmentEntity02.Entites;

namespace AssignmentEntity02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDataContext context = new AppDataContext();
            #region Student
            //var student = new Student()
            //{
            //    FName ="Mohamed",
            //     LName="elbordiny",
            //      Address= "Alex",
            //       DeptId =1
            //};
            //var Result = context.Students.Add(student);
            // student.FName = "Ahmed";
            // student.LName = "Mahmoud";
            // student.Address = "Almin";
            // context.SaveChanges();
            //var Result = context.Students.ToList().Select(s=>s.FName);
            //foreach (var item in Result)
            //    Console.WriteLine(item);
            //update
            //var Result = context.Students.FirstOrDefault(s => s.Id == 2);
            //Result.FName = "Eslam";
            //Result.Address = "Tanta";
            //context.SaveChanges();
            //delete
            //var Result = context.Students.FirstOrDefault(s => s.Id == 3);
            //context.Students.Remove(Result);
            //context.SaveChanges(); 
            #endregion
            #region Department
            //var deparment = new Department()
            //{
            //    Name = "Technology",
            //    HiringDate =  DateTime.Now,
            //    Ins_Id = 1
            //};
            //deparment.Name = "MachineLearining";
            //var Result =context.Departments.Add(deparment);

            //context.SaveChanges();
            //read
            //var Result = context.Departments.ToList().Select(s => s.Name);
            //foreach (var item in Result)
            //    Console.WriteLine(item);
            //update
            //var Result = context.Departments.FirstOrDefault(d => d.Id == 3);
            //Result.HiringDate = DateTime.Now;
            //Result.Name = "Pharmcy";
            //context.SaveChanges();
            //delete
            //var Result = context.Departments.FirstOrDefault(d => d.Id == 3);
            //context.Departments.Remove(Result);
            //context.SaveChanges();


            #endregion
            #region Course
            //var course = new Course()
            //{
            //     Name= "C#",
            //     Description= "Its very Good",
            //      Duration =5,
            //       Top_Id =1

            //};
            //course.Name = "Java";
            //context.Courses.Add(course);
            //context.SaveChanges();
            //read
            //var Result = context.Courses.ToList().Select(c => c.Name);
            //foreach (var result in Result)
            //    Console.WriteLine(result);
            //update
            //var Result = context.Courses.FirstOrDefault(c => c.Id == 2);
            //Result.Name = "DeepLearning";
            //Result.Duration = 8;
            //context.SaveChanges();
            //delete
            //var Result = context.Courses.FirstOrDefault(c => c.Id == 3);
            //context.Courses.Remove(Result);
            //context.SaveChanges();

            #endregion
            #region Instructor
            //var instructor = new Instructor()
            //{
            //    Name = "Mohamed",
            //     Address="Alex",
            //      Salary = 8000,
            //       Bouns=500,
            //        HourRate =100

            //};
            //instructor.Name = "ashraf";
            //instructor.Dept_Id = 1;

            //context.Instructors.Add(instructor);
            //context.SaveChanges();
            //read
            //var Result = context.Instructors.Select(x => x.Name).ToList();
            //foreach (var result in Result)
            //    Console.WriteLine(result);
            //update
            //var Result = context.Instructors.FirstOrDefault(x => x.Id == 4);
            //Result.Salary = 6000;
            //Result.Bouns = 400;
            //Result.Name = "Aya";
            //context.SaveChanges();
            //delete
            //var Result = context.Instructors.FirstOrDefault(x => x.Id == 3);
            //context.Instructors.Remove(Result);
            //context.SaveChanges();

            #endregion
            #region Topics
            //var topic = new Topic() { Name = "Asp.NetMVC" };
            //topic.Name = "WebDevelopement";
            //context.topics.Add(topic);
            //context.SaveChanges();
            //read
            //var Result = context.topics.Select(t => t.Name).ToList();
            //foreach (var result in Result)
            //    Console.WriteLine(result);
            //update
            //var Result = context.topics.FirstOrDefault(t => t.Id == 3);
            //Result.Name = "BackendDeveloper";
            //context.SaveChanges();
            //delete
            //var Result = context.topics.FirstOrDefault(t => t.Id == 3);
            //context.topics.Remove(Result);
            //context.SaveChanges();
            #endregion
            #region CourseStudent
            //var Crstudent = new CourseStudent() { Grade=100 };
            //Crstudent.Grade = 70;
            //Crstudent.Cors_Id = 3;
            //context.courseStudents.Add(Crstudent);
            //context.SaveChanges();
            //read
            //var Result = context.courseStudents.Select(s => s.Grade).ToList();
            //foreach (var result in Result)
            //    Console.WriteLine(result);
            //update
            //var Result = context.courseStudents.FirstOrDefault(x => x.Stud_Id == 100);
            ////Result.Cors_Id = 1;
            //Result.Grade = 95;
            //context.SaveChanges();
            //var Result = context.courseStudents.FirstOrDefault(x => x.Stud_Id == 300);
            //context.courseStudents.Remove(Result);
            //context.SaveChanges();

            #endregion
        }
    }
}
