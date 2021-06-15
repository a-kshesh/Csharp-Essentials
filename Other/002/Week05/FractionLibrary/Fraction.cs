using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionLibrary
{
    public class Fraction
    {
        public int Top { get; }
        public int Bottom { get; }
        public Fraction(int top = 0, int bottom = 1)
        {
            Top = top;Bottom = bottom;
        }
        public override string ToString()
        {
            return $"<{Top}, {Bottom}>";
        }
    }
}
