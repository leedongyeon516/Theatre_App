using System;
using System.Collections.Generic;

namespace Theatre
{
    class Movie
    {
        public string Title { get; }
        public int Year { get; }
        public int Length { get; }
        public List<string> Cast { get; }
        public Genre Genre { get; private set; }

        public Movie(string title, int year, int length)
        {
            Title = title;
            Year = year;
            Length = length;

            Cast = new List<string>();
        }

        public void AddActor(string actor)
        {
            Cast.Add(actor);
        }

        public void SetGenre(Genre genre)
        {
            Genre = genre;
        }

        public override string ToString()
        {
            // Separate the Length property(minute) into two variables - hour and minute
            string hour = Convert.ToString(Length / 60);
            string minute = Convert.ToString(Length % 60);

            // string.Join() method
            string casts = string.Join(", ", Cast);

            return $"{Title} ({Year}) | Runtime ({(Length >= 60 ? hour + "h " + minute + "m" : Length.ToString() + "m")})" +
                   $"\n" +
                   $"\nCasts:\t\t{casts}\nGenre:\t\t{Genre}";
        }
    }
}
