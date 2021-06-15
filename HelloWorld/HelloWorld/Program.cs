using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 32,b=32;
            Console.WriteLine("Hello World!");
            Console.WriteLine(a);
            if (a==b)
            { Console.WriteLine("{a} is equals to {b}"); }
            book aa = new book();
            Console.WriteLine(aa.ToString());
            book bb = new book(12, "Skill Set");
            Console.WriteLine(bb.ToString());
        }
    }

    class book
    {
        private int bookid;
        private string bookname;

        public book(int bookid=1,string bookname="programming 2")
        {
            this.bookid = bookid;
            this.bookname = bookname;
        }
        public void setBookname()
        {
            this.bookid = bookid;
            this.bookname = bookname;
        }

        public override string ToString()
        {
            return $"BookID={bookid}, BookName={bookname}";
        }

    }
}
