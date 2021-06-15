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
            Rectangle r = new Rectangle(8,3);
            Console.WriteLine($"The area is: {r.getarea()}");
            Console.WriteLine();
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
            return $"[{length},{width}]";
        }

        public int getarea()
        {
            return length * width;
        }
    }
}
