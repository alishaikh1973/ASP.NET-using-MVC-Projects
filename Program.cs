using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoObjectDemo
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Salary { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>()
            {
                new Employee{Id=1,Name="Rohan",City="Pune",Salary=25000},
                new Employee{Id=2,Name="Kishor",City="Mumbai",Salary=26000},
                new Employee{Id=3,Name="Tushar",City="Nagpur",Salary=23000},
                new Employee{Id=4,Name="Amol",City="Pune",Salary=28000},
                new Employee{Id=5,Name="Trupti",City="Satara",Salary=22000},
                new Employee{Id=6,Name="Pradnya",City="Pune",Salary=26000},
                new Employee{Id=7,Name="Payal",City="Mumbai",Salary=29000},
                new Employee{Id=8,Name="Suraj",City="Nashik",Salary=27000},
                new Employee{Id=9,Name="Rohit",City="Solapur",Salary=21000},
                new Employee{Id=10,Name="Sandesh",City="Nagpur",Salary=22000},
                new Employee{Id=11,Name="Ananta",City="Pune",Salary=22500},
            };


            var result = from e in Employees
                         where e.City == "Pune"
                         select e;


            //foreach (Employee item in result)
            //{
            //    Console.WriteLine($"{item.Id}, {item.Name},{item.City},{item.Salary}");
            //}


            var result2 = from e in Employees
                          where e.Name.StartsWith("P")
                          select e;


            //foreach (Employee item in result2)
            //{
            //    Console.WriteLine($"{item.Id}, {item.Name},{item.City},{item.Salary}");
            //}


            var result3 = from e in Employees
                          where e.Salary > 24000 && e.City == "Pune"
                          select e;


            //foreach (Employee item in result3)
            //{
            //    Console.WriteLine($"{item.Id}, {item.Name},{item.City},{item.Salary}");
            //}


            //var result4 = Employees.Where(x => x.City == "Mumbai").ToList();
            var result4 = Employees.Where(x => x.City == "Pune").OrderBy(x => x.Salary).ToList();
            foreach (Employee item in result4)
            {
                Console.WriteLine($"{item.Id}, {item.Name},{item.City},{item.Salary}");
            }


        }

    }
}

