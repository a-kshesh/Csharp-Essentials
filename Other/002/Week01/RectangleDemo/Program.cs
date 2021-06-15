using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 7);
            Console.WriteLine(r);
            Console.WriteLine($"Area:{r.GetArea()}");
        }
    }

    class Rectangle
    {
        private int length;
        private int width;
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        public override string ToString()
        {
            return $"[{length}, {width}]";
        }
        public int GetArea()
        {
            return length * width;
        }
    }
}
