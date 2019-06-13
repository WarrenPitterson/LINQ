using System;
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
            Func<int, int> square = x => x*x;
            Func<int, int, int> add = (x, y) =>
            {
                int temp = x + y;
                return temp;
            };
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee {Id = 1, Name = "Warren"},
                new Employee {Id = 2, Name = "Liam"},
                new Employee {Id = 3, Name = "Steven"}
            };

            Console.WriteLine(square(add(3,5)));

            var sales = new List<Employee>()
            {
                new Employee {Id = 4, Name = "Alan"}
            };


            var query = developers.Where(e => e.Name.Length == 6)
                                    .OrderBy(e => e.Name);

            foreach (var employee in query)
            {
                Console.WriteLine(employee.Name);
            }

        }

        private static bool NameStartsWithW(Employee employee)
        {
            return employee.Name.StartsWith("W");
        }
    }
}
