using EntityframeworkCoreDay02.Context;
using EntityframeworkCoreDay02.Entites;
namespace EntityframeworkCoreDay02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Department department = new Department();
            //department.Manager
            ///CRUD Operation Read Update Delete Create
            //AppContextLayer layer = new AppContextLayer();

            //try
            //{
            //    //code
            //}
            //finally
            //{
            //layer.Dispose();

            //}
            //using(AppContextLayer layer = new AppContextLayer())//Resource
            //{
            //    //CruD
            //}
            using AppContextLayer context = new AppContextLayer();
            #region Create insert
            ///Create insert
            //var employee = new Employee()
            //{
            //    Name = "ahmed ashraf",
            //    Salary = 15000,
            //    Address = "Cairo",
            //    Age = 28
            //};
            //context.Add(employee);

            //Console.WriteLine(context.Entry(employee).State);//Detached
            //employee.Name = "Miso";
            //Console.WriteLine(context.Entry(employee).State);//Detached
            //context.Employees.Add(employee);
            //Console.WriteLine(context.Entry(employee).State);//Added
            //var Result = context.SaveChanges();
            //Console.WriteLine(context.Entry(employee).State);//Unchanged
            //employee.Name = "Omar";
            //Console.WriteLine(context.Entry(employee).State);//Modified

            //Console.WriteLine(Result);
            //context.Employees.Add(employee);
            //context.SaveChanges();

            #endregion
            #region Read-select
            //var Result= context.Employees.FirstOrDefault(E => E.Id == 20);
            // Console.WriteLine(context.Entry(Result).State);//Unchanged
            // Result.Name = "Ali";
            // Console.WriteLine(context.Entry(Result).State);//Modified-> Tracked happens Change

            // Console.WriteLine(Result?.Name);
            // Console.WriteLine(Result?.Id);
            //var Result = context.Employees.ToList().Select(E=>E.Name);
            // foreach (var item in Result) 
            // {
            //     Console.WriteLine(item);
            // }
            #endregion
            #region Update
            //var Result = context.Employees.FirstOrDefault(E => E.Id == 30);
            //Console.WriteLine(context.Entry(Result).State);//Unchanged
            ////Result.Name = "Aya Yara";
            ////Console.WriteLine(context.Entry(Result).State);//Modified
            //context.Update(Result);
            //Console.WriteLine(context.Entry(Result).State);//Modified
            ////context.SaveChanges();
            //Console.WriteLine(context.Entry(Result).State);
            #endregion
            #region Delete
            var Result = context.Employees.FirstOrDefault(E => E.Id == 40);
            Console.WriteLine(context.Entry(Result).State);//Unchanged
            context.Employees.Remove(Result);
            Console.WriteLine(context.Entry(Result).State);//Deleted
            context.SaveChanges();
            Console.WriteLine(context.Entry(Result).State);//Detached
            #endregion



        }
    }
}
