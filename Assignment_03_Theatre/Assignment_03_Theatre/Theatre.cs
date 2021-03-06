﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Flags]
public enum MovieDay
{
    Sun = 0,
    Mon = 1,
    Tue = 2,
    Wed = 4,
    Thu = 8,
    Fri = 16,
    Sat = 32
}

namespace Assignment_03_Theatre
{
    class Theatre
    {
        private List<Show> Shows { get; set; }
        private string Name { get; set; }

        public Theatre(string name)
        {
            Name = name;
            Shows = new List<Show>();
        }

        public void AddShow(Show show)
        {
            Shows.Add(show);
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
                if (s.Movie.Genre.HasFlag(genre) == true)
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
                if (s.Time.Hours == time.Hours)
                    Console.WriteLine(s);
            }
        }

        public void PrintShows(string actor)
        {
            foreach (Show s in Shows)
            {
                if (s.Movie.Cast.Contains(actor))
                    Console.WriteLine(s);
            }
        }
    }
}
