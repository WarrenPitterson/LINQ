﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee {Id = 1, Name = "Warren"},
                new Employee {Id = 2, Name = "Liam"},
            };

            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee {Id = 3, Name = "Alan"}
            };

            foreach (var employee in developers.Where(
                delegate (Employee employee)
            {
                return employee.Name.StartsWith("W");
            }))
            {
                Console.WriteLine(employee.Name);
            }


            //Console.WriteLine(developers.Count());

            //IEnumerator<Employee> enumerator = developers.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current.Name);
            //}

        }

        private static bool NameStartsWithW(Employee employee)
        {
            return employee.Name.StartsWith("W");
        }
    }
}
