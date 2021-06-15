using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDemo
{
    struct Age
    {
        public int Month { get; }
        public int Day { get; }

        public Age(int day, int month)
        {
            this.Month = month;
            this.Day = day;
        }

        public override string ToString()
        {
            return $" {Month} Mos {Day} Days ";
        }
    }
}
