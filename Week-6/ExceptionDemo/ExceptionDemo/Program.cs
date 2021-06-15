using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Division(1,0);
            //DevisionWithExceptionHandling();
            //DivisionHandling();
            //DivisionWithExceptionHandlingMoreInfo();
            //DivisionWithExceptionHandlingMoreInfo();
            //DivisionWithExceptionHandlingThrow();
            //GeneratingException();
            HandlingRandomException();

        }

        public static int Division(int top, int bottom) => top / bottom;

        public static void DivisionHandling()
        {
            //call the Division method with argument 1 and 0 
            Division(1, 0);
            //this will terminate your application
        }

        public static void DevisionWithExceptionHandling()
        {
            //call the Division method with argument 1 and 0 
            try { Division(1, 0); }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void DivisionWithExceptionHandlingMoreInfo()
        {
            //call the Division method with argument 1 and 0 
            //You will catch the exception and print the associated message
            //your application should not crash

            try { Division(1, 0); }
            catch (Exception e)
            {
                Console.WriteLine("Exception in Devision " + e.Message);
            }


        }

        public static void DivisionWithExceptionHandlingThrow()
        {  //call the Division method with argument 1 and 0  
            //You will catch the exception and print the associated message
            //You should create and throw a new exception  
            //your application will crash}
            try { Division(1, 0); }
            catch (Exception e)
            {
                Console.WriteLine("Exception in Devision" + e.Message);
                throw new Exception("this is new throwed eception");
            }
        }

        public static void GeneratingException()
        {  //You should create and throw a new exception  
            try { Division(1, 0); }
            catch (Exception e)
            {
                throw new Exception("this is new throwed eception");
            }

            //your application will crash

        }

        public static void GeneratingCustomException()
        {
            throw new ExceptionDemo("this is exception demo failed");
        }

        public static void GeneratingRandomException()
        {
            int exceptionType = new Random().Next() % 4;
            switch (exceptionType)
            {
                case 0:
                    throw new IndexOutOfRangeException();
                case 1:
                    throw new NullReferenceException();
                case 2:
                    throw new InvalidOperationException();
                case 3:
                    throw new InvalidCastException();
            }
        }


        public static void HandlingRandomException()
        {
            try
            {
                GeneratingRandomException();
            }

            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            //You should call the method below and catch all the possible exceptions
            //your application will not crash
        }


    }

    class ExceptionDemo : Exception
    {
        public ExceptionDemo(string errorMessage)
            :base(errorMessage)
        {

        }
    }
}
