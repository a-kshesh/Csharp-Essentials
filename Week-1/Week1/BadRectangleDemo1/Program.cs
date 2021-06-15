using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadRectangleDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            BadRectangle rect;
            rect = new BadRectangle();
            rect.length = 8;
            rect.width = 3;
            Console.WriteLine(rect);
            DescribeRectangle(rect);
        }
        static void DescribeRectangle(BadRectangle r)
        {
            Console.WriteLine($"lenght:{r.length}, width:{r.width}");
        }
    }
    class BadRectangle
    {
        public int length;
        public int width;
    }
}
