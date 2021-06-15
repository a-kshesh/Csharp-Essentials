using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalc
{
    class Fraction
    {
        public int Top { get; private set; }

        public int Bottom { get; private set; }

        public Fraction(int top = 0, int bottom = 1) { Top = top; Bottom = bottom; }

        public static Fraction operator +(Fraction left, Fraction right)
        {
            return new Fraction(left.Top * right.Bottom + right.Top * left.Bottom, left.Bottom * right.Bottom);
        }
        public static Fraction operator -(Fraction left, Fraction right)
        {
            return new Fraction(left.Top * right.Bottom - right.Top * left.Bottom, left.Bottom * right.Bottom);
        }

        /**
         * method which overrides multiply operator
         */
        public static Fraction operator *(Fraction left, Fraction right)
        {
            return new Fraction(left.Top * right.Top, left.Bottom * right.Bottom);
        }

        /**
         * /**
         * method which overrides division operator
         */
        public static Fraction operator /(Fraction left, Fraction right)
        {
            return new Fraction(left.Top * right.Bottom, left.Bottom * right.Top);
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]", Top, Bottom);
        }
    }
}

