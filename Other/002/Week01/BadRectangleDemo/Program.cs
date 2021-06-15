using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadRectangleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BadRectangle rect;  //delcarationg of the object
            rect = new BadRectangle();
            rect.length = 8;
            rect.width = 3;
            Console.WriteLine(rect);
            DescribeRectangle(rect);
        }
        static void DescribeRectangle(BadRectangle r)
        {
            Console.WriteLine($"Length:{r.length}, width:{r.width}");
        }
    }

    class BadRectangle
    {
        public int length;
        public int width;
    }
}
