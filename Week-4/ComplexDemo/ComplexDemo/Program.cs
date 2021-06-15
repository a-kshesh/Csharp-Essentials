using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex com = new Complex(2, 3);
            Complex c0 = new Complex(-2, 3);
            Complex c1 = new Complex(-2, 3);
            Complex c2 = new Complex(1, -2);
            Console.WriteLine(c1);
            Console.WriteLine(c2);

            //Console.WriteLine($"{c1} + {c2} = {c1 + c2}");
            Console.WriteLine($"{c1} - {c2} = {c1 - c2}");
            Console.WriteLine($"{c0} {(c0 == c1 ? "=" : "!=")} {c1}");
            Console.WriteLine($"{c0} {(c0 == c2 ? "=" : "!=")} {c2}");
            Console.WriteLine($"{c2} in polar form is {c2.Modulus:f2}cis({c2.Argument:f2})");
        }
    }
    class Complex
    {
        public int real { get; }
        public int imaginary { get; }
        public double Argument
        {
            get
            {
                return Math.Sqrt((real * real) + (imaginary * imaginary));

            }
        }
        public double Modulus
        {
            get
            {
                return Math.Atan(imaginary / real);
            }
        }

        public Complex(int real = 0, int imaginary = 0)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public static Complex operator -(Complex lhs, Complex rhs)

        {
            int real = lhs.real - rhs.real;
            int imaginary = lhs.imaginary - rhs.imaginary;
            return new Complex(real, imaginary);
        }
        public override string ToString()
        {
            return $"<{real},{imaginary}>";
        }
    }

}
