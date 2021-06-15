using System;

namespace Rational
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational bb = new Rational();
            Rational cc = new Rational(3);
            Rational dd = new Rational(3, 2);
            Rational other = new Rational(5, 6);
            Console.WriteLine($"Number 1:{bb}");
            Console.WriteLine($"2nd Number:{cc}");
            Console.WriteLine($"3rd Number:{dd}");
            Console.WriteLine($"4th Number:{other}");
            dd.IncreaseBy(other);
            Console.WriteLine($"Addition of {other} with 3rd rational number = {dd}");
            cc.DecreaseBy(other);
            Console.WriteLine($"Subtraction of {other} from 2nd rational number = {cc}");
        }
    }

    class Rational
    {
        private int denominator, numerator;

        public Rational(int numerator=0, int denominator=1)
        {
            this.denominator = denominator;
            this.numerator = numerator;
        }

        public void IncreaseBy(Rational other)
        {
            if (this.denominator == other.denominator)
            {
                this.numerator = numerator + other.numerator;
            }
            else
            {
                this.numerator = (numerator * other.denominator) + (other.numerator * denominator);
                this.denominator = (denominator*other.denominator);
            }


        }

        public void DecreaseBy(Rational other)
        {
            if (this.denominator== other.denominator)
            {
                this.numerator = numerator - (other.numerator);
            }
            else
            {
                this.numerator = (numerator * other.denominator)-(other.numerator * this.denominator);
                this.denominator = (denominator * other.denominator);
            }
        }

        public override string ToString()
        {
            return $"Numerator is:{numerator} and Denominator is:{denominator}";
        }
    }
}
