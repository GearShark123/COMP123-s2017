using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_Theatre
{
    class Theatre
    {
        private List<Show> Shows { get; set; }
        private string Name { get; set; }

        public Theatre(string name)
        {

        }

        public void AddShow(Show show)
        {

        }

        public void PrintShows()
        {
            foreach (Show s in Shows)
            {
                Console.WriteLine(s);
            }
        }

        public void PrintShows(MovieGenre genre)
        {
            foreach (Show s in Shows)
            {
                if (s.Movie.Genre == genre)
                    Console.WriteLine(s);
            }
        }

        public void PrintShows(MovieDay day)
        {
            foreach (Show s in Shows)
            {
                if (s.Day == day)
                    Console.WriteLine(s);
            }
        }

        public void PrintShows(Time time)
        {
            foreach (Show s in Shows)
            {
                if (s.Time == time)
                    Console.WriteLine(s);
            }
        }
    }
}
