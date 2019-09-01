using System;
using System.Collections.Generic;

namespace Theatre
{
    class Theatre
    {
        private List<Show> shows;

        public string Name { get; }

        public Theatre(string name)
        {
            Name = name;
            shows = new List<Show>();
        }

        public void AddShow(Show show)
        {
            shows.Add(show);
        }

        public void PrintShows()
        {
            int counter = 1;

            foreach (Show show in shows)
            {
                // Set the numbers' color to Red
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" {counter++}");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine($"\n{show}\nTheatre:\t{Name}\n");
            }
        }

        public void PrintShows(Genre genre)
        {
            int counter = 1;

            foreach (Show show in shows)
            {
                if (show.Movie.Genre.HasFlag(genre))
                {
                    // Set the numbers' color to Cyan
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($" {counter++}");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine($"\n{show}\nTheatre:\t{Name}\n");
                }
            }
        }

        public void PrintShows(Day day)
        {
            int counter = 1;

            foreach (Show show in shows)
            {
                if (show.Day == day)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($" {counter++}");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine($"\n{show}\nTheatre:\t{Name}\n");
                }
            }
        }

        public void PrintShows(Time time)
        {
            int counter = 1;

            foreach (Show show in shows)
            {
                if (show.Time == time)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($" {counter++}");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine($"\n{show}\nTheatre:\t{Name}\n");
                }
            }
        }

        public void PrintShows(string actor)
        {
            int counter = 1;

            foreach (Show show in shows)
            {
                if (show.Movie.Cast.Contains(actor))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($" {counter++}");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine($"\n{show}\nTheatre:\t{Name}\n");
                }
            }
        }

        public void PrintShows(Day day, Time time)
        {
            int counter = 1;

            foreach (Show show in shows)
            {
                if (show.Day == day && show.Time == time)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($" {counter++}");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine($"\n{show}\nTheatre:\t{Name}\n");
                }
            }
        }
    }
}
