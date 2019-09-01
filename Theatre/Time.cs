using System;

namespace Theatre
{
    class Time
    {
        public int Hours { get; }
        public int Minutes { get; }
        public int Seconds { get; }

        public Time(int hours, int minutes, int seconds = 0)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public static bool operator ==(Time lhs, Time rhs)
        {
            int lhsMinutes = lhs.Hours * 60 + lhs.Minutes;
            int rhsMinutes = rhs.Hours * 60 + rhs.Minutes;

            return Math.Abs(lhsMinutes - rhsMinutes) < 15;
        }

        public static bool operator !=(Time lhs, Time rhs)
        {
            int lhsMinutes = lhs.Hours * 60 + lhs.Minutes;
            int rhsMinutes = rhs.Hours * 60 + rhs.Minutes;

            return !(Math.Abs(lhsMinutes - rhsMinutes) < 15);
        }

        public override string ToString()
        {
            return $"{Hours % 12}:{Minutes:d2}:{Seconds:d2} {(Hours < 12 ? "AM" : "PM")}";
        }
    }
}
