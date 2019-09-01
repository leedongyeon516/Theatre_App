namespace Theatre
{
    class Show
    {
        public Movie Movie { get; }
        public Day Day { get; }
        public double Price { get; }
        public Time Time { get; }

        public Show(Movie movie, Day day, double price, Time time)
        {
            Movie = movie;
            Day = day;
            Price = price;
            Time = time;
        }

        public override string ToString()
        {
            return $"{Movie}\nDay:\t\t{Day}\nShowtime:\t{Time}\nPrice:\t\t{Price:c}";
        }
    }
}
