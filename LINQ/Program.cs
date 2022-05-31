using System;
using System.Collections.Generic;
using System.Linq;


namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Main");
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<Employee> employees = new List<Employee>();
            using (var context = new EmployeeContext())
                for (int i = 1; i <= 5000; i++)
            {
                Employee mEmployee = new Employee();
                //mEmployee.Id = i;
                mEmployee.FName = "Tom_" + i;
                mEmployee.LName = "Last_" + i;
                mEmployee.MName = "Middle_" + i;
                mEmployee.ContactNo = "222222222222";
                mEmployee.Address = "dfsdfsdfffs";
                mEmployee.City = "gg";
                mEmployee.Pincode = "56412";
                mEmployee.Dept = "IT";
                mEmployee.DOB = "12-08-1989";
                mEmployee.DOJ = "12-08-1989";
                mEmployee.Email = "mark@gmail.com";
                mEmployee.Salary = "50000";
                //employees.Add(mEmployee);
                    context.Employees.Add(mEmployee);
                    context.SaveChanges();
                    
                    //Console.WriteLine("Id : {0},Name:{1}", i, "Tom_"+i);
                    //Console.WriteLine("Id : {0},Name:{1}", i, "Tom_"+i);
                }
            ////Using IEnumerable
            //IEnumerable<Employee> query = from emp in employees
            //                              where emp.Id == 1
            //                              select emp;

            Console.WriteLine("Start List");
            Console.WriteLine("Start time : " + DateTime.Now.ToLongTimeString());
            var query = (from emp in employees 
                         select emp).ToList();
            Console.WriteLine("End time : " + DateTime.Now.ToLongTimeString());
            Console.WriteLine("End list");

            Console.WriteLine("========================");
            Console.WriteLine("Start IEnumerable");
            Console.WriteLine("Start time : " + DateTime.Now.ToLongTimeString());
            var query1 = (from emp in employees
                         select emp).AsQueryable();
            Console.WriteLine("End time : " + DateTime.Now.ToLongTimeString());
            Console.WriteLine("End IEnumerable");

            Console.WriteLine("========================");

            Console.WriteLine("Start IQuereable");
            Console.WriteLine("Start time : " + DateTime.Now.ToLongTimeString());
           IEnumerable< Employee> query2= (from emp in employees
                          select emp).AsEnumerable();
            Console.WriteLine("End time : " + DateTime.Now.ToLongTimeString());
            Console.WriteLine("End IQuereable");

            //foreach (var item in query)
            //{
            //    Console.WriteLine($"Id = {item.Id}, Name= {item.Name}");
            //}



            //Using IQueryable
            //IQueryable<Employee> query1 = employees.AsQueryable().Where(x => x.Id == 2);

            //foreach (var item in query)
            //{
            //    Console.WriteLine("Id = " + item.Id + " Name = " + item.Name);
            //}

            //foreach (var item in query1)
            //{
            //    Console.WriteLine("Id = " + item.Id + " Name = " + item.Name);
            //}

            Console.ReadLine();
            
        }


    }
}
