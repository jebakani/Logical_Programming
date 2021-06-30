using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class FibonacciSeries
    {
        public  void ReadInput()
        {
            Console.WriteLine("Welcome to fibonacci Series");
            //Reading input from user
            Console.WriteLine("Enter the nth number:");
            int seriesLength = Convert.ToInt32(Console.ReadLine());
            FindFibonacciSeries(seriesLength);

        }

        //method to print fibonacci series
        private static void FindFibonacciSeries(int fibo)
        {
            int fib0 = 0;
            int fib1 = 1;
            int fiboNext = 0;
            Console.Write("{0} {1} ", fib0, fib1);
            for (int iter = 2; iter < fibo; iter++)
            {
                //add perivous two number to print next number
                fiboNext = fib0 + fib1;
                Console.Write("{0} ", fiboNext);

                //replace the current number with next number
                fib0 = fib1;
                fib1 = fiboNext;

            }
        }

    }
}
