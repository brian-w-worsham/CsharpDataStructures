using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDataStructures
{
    internal class SortingAList
    {
        internal static void Run()
        {
            List<int> ints = new List<int> { 1, 9, 2, 5, 3, 7, 10 };
            List<string> strings = new List<string> { "One", "Two", "Three", "Four", "Five" };

            ints.Sort(); // Ascending order
            ints.Reverse();
            strings.Sort();

            List<Employee> employees = new List<Employee>
            {
                new Employee() {
                    Id = 1,
                    Gender = "Male",
                    Name = "Name1",
                    Salary = 100000
                },
                new Employee() {
                    Id = 6,
                    Gender = "Male",
                    Name = "Name2",
                    Salary = 100000
                },
                new Employee() {
                    Id = 4,
                    Gender = "Male",
                    Name = "Name3",
                    Salary = 100000
                },
                new Employee() {
                    Id = 9,
                    Gender = "Male",
                    Name = "Name4",
                    Salary = 100000
                },
            };

            // no criteria specified for sorting the employees
            // must implement IComparable interface
            employees.Sort();//System.InvalidOperationException: 'Failed to compare two elements in the array.'

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Id + " " + employee.Name + " " + employee.Salary);
            }

        }
    }

    internal class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Employee other)
        {
            /*
             * > 0 - this instance is greater than the other instance
             * = 0 - this instance is equal to the other instance
             * < 0 - this instance is less than the other instance
             */

            if(this.Salary > other.Salary)
            {
                return 1;
            }
            else if(this.Salary < other.Salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
