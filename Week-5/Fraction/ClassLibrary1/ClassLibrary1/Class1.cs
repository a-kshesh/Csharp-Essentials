using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Fraction
    {
       public int top { get; }
       public int bottom { get; }

        public Fraction(int top=0, int bottom=0)
        {
            this.top = top;
            this.bottom = bottom;
        }

        public static Fraction operator +(Fraction left, Fraction right)
        {
            int top = (left.top*right.bottom) + (right.top*left.bottom);
            int bottom = left.bottom + right.bottom;
            return new Fraction(top,bottom);
        }

        public static Fraction operator -(Fraction left, Fraction right)
        {
            int top = (left.top * right.bottom) - (right.top * left.bottom);
            int bottom = left.bottom - right.bottom;
            return new Fraction(top, bottom);
        }

        public override string ToString()
        {
            return $"<{top}> <{bottom}>";
        }

       
    }


}
