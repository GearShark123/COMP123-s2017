using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_Theatre
{
    enum MovieDay { Sun, Mon, Tue, Wed, Thu, Fri, Sat }

    class Show
    {
        public double Price { get; private set; }
        public MovieDay Day { get; private set; }
        public Movie Movie { get; private set; }
        public Time Time { get; private set; }

        public Show(Movie movie, MovieDay day, double price, Time time)
        {
            this.Movie = movie;
            this.Day = day;
            this.Price = price;
            this.Time = time;
        }

        public override string ToString()
        {
            return string.Format("{0}\n\tat {1} {2} {3:c}", Movie, Day, Time, Price);
        }
    }
}
