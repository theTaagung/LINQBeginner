using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQBeginner
{
    class Program
    {
        public static List<Employee> employees = new List<Employee>();
        public static List<Project> projects = new List<Project>();

        static void Main(string[] args)
        {
            InitializeEmployees();
            InitializeProjects();

            //WHERE
            //var querySyntax = from employee in employees
            //                  where employee.EmployeeName.StartsWith("J")
            //                  select employee.EmployeeName;


            //var methodSyntax = employees.Where(e => e.EmployeeName.StartsWith("J"));

            //foreach (var item in querySyntax) {
            //    Console.WriteLine(item);
            //}


            //ORDER BY DESCENDING
            //var querySyntax = from employee in employees
            //                  orderby employee.EmployeeName descending
            //                  select employee.EmployeeName;


            //var methodSyntax = employees.OrderByDescending(e => e.EmployeeName);

            //foreach (var item in querySyntax)
            //{
            //    Console.WriteLine(item);
            //}

            //ORDER BY ASCENDING
            //var querySyntax = from employee in employees
            //                  orderby employee.EmployeeName
            //                  select employee.EmployeeName;


            //var methodSyntax = employees.OrderBy(e => e.EmployeeName);

            //foreach (var item in querySyntax)
            //{
            //    Console.WriteLine(item);
            //}


            //THEN BY
            //var querySyntax = from employee in employees
            //                  orderby employee.ProjectId, employee.EmployeeName descending
            //                  select employee.EmployeeName;


            //var methodSyntax = employees.OrderBy(e => e.ProjectId).ThenByDescending(e => e.EmployeeName);

            //foreach (var item in querySyntax)
            //{
            //    Console.WriteLine(item);
            //}

            //TAKE
            //var querySyntax = (from employee in employees
            //                   select employee).Take(2);


            //var methodSyntax = employees.Take(2);

            //foreach (var item in querySyntax)
            //{
            //    Console.WriteLine(item.EmployeeName);
            //}



            //GROUP
            //var querySyntax = from employee in employees
            //                  group employee by employee.ProjectId;


            //var methodSyntax = employees.GroupBy(e => e.ProjectId);

            //foreach (var item in querySyntax)
            //{
            //    Console.WriteLine(item.Key + ":" + item.Count());
            //}


            //FIRST
            //var querySyntax = (from employee in employees
            //                   select employee).FirstOrDefault();

            //var methodSyntax = employees.FirstOrDefault();

            //if (querySyntax != null) {
            //    Console.WriteLine(querySyntax.EmployeeName);
            //}


            //JOIN
            //var querySyntax = from employee in employees
            //                  join project in projects on employee.ProjectId equals project.ProjectId
            //                  select new { employee.EmployeeName, project.ProjectName };

            //var methodSyntax = employees.Join(projects,
            //                                  e => e.ProjectId,
            //                                  p => p.ProjectId,
            //                                  (e, p) => new { e.EmployeeName, p.ProjectName });

            //foreach (var item in querySyntax)
            //{
            //    Console.WriteLine(item.EmployeeName + ":" + item.ProjectName);
            //}



            //LEFT JOIN
            //var querySyntax = from employee in employees
            //                  join project in projects on employee.ProjectId equals project.ProjectId into group1 
            //                  from project in group1.DefaultIfEmpty()
            //                  select new { employee.EmployeeName, ProjectName = project ? .ProjectName ?? "NULL"};

            //var methodSyntax = employees.Join(projects,
            //                                  e => e.ProjectId,
            //                                  p => p.ProjectId,
            //                                  (e, p) => new { e.EmployeeName, p.ProjectName });

            //foreach (var item in querySyntax)
            //{
            //    Console.WriteLine(item.EmployeeName + ":" + item.ProjectName);
            //}


        }

        public static void InitializeEmployees()
        {
            employees.Add(new Employee
            {
                EmployeeId = 1,
                EmployeeName = "John",
                ProjectId = 100
            });

            employees.Add(new Employee
            {
                EmployeeId = 2,
                EmployeeName = "Jennifer",
                ProjectId = 101
            });

            employees.Add(new Employee
            {
                EmployeeId = 3,
                EmployeeName = "Sam",
                ProjectId = 101
            });
        }

        public static void InitializeProjects()
        {
            projects.Add(new Project
            {
                ProjectId = 100,
                ProjectName = "ABC"

            });

            projects.Add(new Project
            {
                ProjectId = 101,
                ProjectName = "PQR"

            });

        }
    }
}

