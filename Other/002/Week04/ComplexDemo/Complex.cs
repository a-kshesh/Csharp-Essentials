using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexDemo
{
    class Complex
    {
        public int Real { get; }
        public int Imaginary { get; }
        public Complex(int real = 0, int imaginary = 1)
        {
            Real = real; Imaginary = imaginary;
        }
        public override string ToString() => $"<{Real}, {Imaginary}>";

        public static Complex operator +(Complex lhs, Complex rhs)
            => new Complex(lhs.Real + rhs.Real, lhs.Imaginary + rhs.Imaginary);

        public static Complex operator -(Complex lhs, Complex rhs)
             => new Complex(lhs.Real - rhs.Real, lhs.Imaginary - rhs.Imaginary);

        public static bool operator ==(Complex lhs, Complex rhs)
            => lhs.Real == rhs.Real && lhs.Imaginary == rhs.Imaginary;

        public static bool operator !=(Complex lhs, Complex rhs)
            => lhs.Real != rhs.Real || lhs.Imaginary != rhs.Imaginary;
    }
}
