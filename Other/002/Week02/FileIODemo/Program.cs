using System;
using System.Collections.Generic;

//STEP I - include the necessary namespace
using System.IO;
namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteFile("test.txt");
            //ReadFile("test.txt");
        }
        static void ReadFile(string filename)
        {
            //STEP II - create and initialize object to read file
            TextReader reader = new StreamReader(filename);

            //STEP III - perform reading
            string line = reader.ReadLine();
            Console.WriteLine(line);

            //STEP IV - close the file
            reader.Close();
        }
        static void WriteFile(string filename)
        {
            //STEP II - create and initialise the object to write to a file
            TextWriter writer = new StreamWriter(filename);

            //STEP III - perform the necessary writes
            writer.WriteLine("Programming is fun!");
            writer.WriteLine("Narendra is a genius");
            writer.WriteLine("********************");

            for (int i = 1; i <= 10; i++)
            {
                writer.WriteLine($"12 * {i} = {12 * i}");
            }
            //STEP IV - close the file object
            writer.Close();
        }
    }
}
