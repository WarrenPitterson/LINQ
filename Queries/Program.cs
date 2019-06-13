using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var films = new List<Films>
            {
                new Films { Title = "Avengers End Game", Rating = 9, Year = 2019 },
                new Films { Title = "John Wick 3", Rating = 8, Year = 2019 },
                new Films { Title = "X Men - Rise of the phoenix", Rating = 5, Year = 2019 },
                new Films { Title = " Aladdin", Rating = 7, Year = 2019 },
                new Films { Title = "The Green Book", Rating = 9, Year = 2019 }
            };

            var query = films.Where(f => f.Year == 2019);
            
            foreach (var film in query)
            {
                Console.WriteLine(film.Title);
            }
        }
    }
}
