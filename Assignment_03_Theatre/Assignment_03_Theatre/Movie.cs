using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Flags]
public enum MovieGenre
{
    Unrated = 0,
    Action = 1,
    Romance = 2,
    Documentary = 4,
    Mystery = 8,
    Musical = 16,
    Horror = 32,
    Comedy = 64
}

namespace Assignment_03_Theatre
{
    class Movie
    {
        public int Length { get; private set; }
        public string Title { get; private set; }
        public MovieGenre Genre { get; private set; }
        public List<string> Cast { get; private set; }

        public Movie(string name, int length)
        {
            Cast = new List<string>();

            this.Title = name;
            this.Length = length;
        }

        public void AddActor(string actor)
        {
            Cast.Add(actor);
        }

        public void SetGenre(MovieGenre genre)
        {
            Genre = genre;
        }

        public override string ToString()
        {
            return string.Format("Title: {0}, Length: {1}", Title, Length); 
        }
    }
}
