using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_Theatre
{
    class Time
    {
        public int Hours { get; }
        public int Minutes { get; }
        public int Seconds { get; }

        public Time(int hours, int minutes, int seconds = 0)
        {
            this.Hours = hours;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public override string ToString()
        {
            return $"{Hours}:{Minutes}:{Seconds}";
        }

        public static bool operator ==(Time lhs, Time rhs)
        {
            
            double diff = TimeSpan.Parse(lhs.ToString()).Subtract(TimeSpan.Parse(rhs.ToString())).TotalMinutes;
            diff = diff < 0 ? (diff * -1) : diff; 
            if (diff < 15)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }
        public static bool operator != (Time lhs, Time rhs)
        {
            return true;
        }
    }
}
