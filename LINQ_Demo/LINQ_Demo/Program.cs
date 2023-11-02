using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Demo
{

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Salary { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>()
            {
                new Employee{ Id = 1,Name="Vishwanath",City="Pune",Salary=30000},
                 new Employee{ Id = 2,Name="Sagar",City="Satara",Salary=25000},
                  new Employee{ Id = 3,Name="Suraj",City="Solapur",Salary=26000},
                   new Employee{ Id = 4,Name="Poonam",City="Pune",Salary=32000},
                    new Employee{ Id = 5,Name="Sandhya",City="Mumbai",Salary=28000},
                     new Employee{ Id = 6,Name="Priya",City="Nashik",Salary=30000},
                      new Employee{ Id = 7,Name="Vishal",City="Pune",Salary=27000},
                       new Employee{ Id = 8,Name="Arohi",City="Nagpur",Salary=25000},
                        new Employee{ Id = 9,Name="Shubham",City="Pune",Salary=29000},
                         new Employee{ Id = 10,Name="Ayush",City="Nagpur",Salary=50000},
                          new Employee{ Id = 11,Name="Neha",City="Mumbai",Salary=40000},
            };

            // ********** Using LINQ 
            /*var result = from e in Employees
                         where e.City == "Pune"
                         select e;
            foreach(Employee item in result)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.City},{item.Salary}");
            }*/

            /* var result2 = from e in Employees
                           where e.Salary > 24000 && e.City == "Pune"
                           select e;
             foreach (Employee item in result)
             {
                 Console.WriteLine($"{item.Id},{item.Name},{item.City},{item.Salary}");
             }*/


            //  *********Using Lambda Expression 
            //var result4 = Employees.Where(x => x.City == "Mumbai").ToList();
            var result4 = Employees.Where(x => x.City == "Mumbai").OrderBy(x => x.Salary).ToList();
            foreach (Employee item in result4)
            {
                Console.WriteLine($"{item.Id}, {item.Name},{item.City},{item.Salary}");
            }


        }
    }
}
