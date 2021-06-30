using System;

namespace LogicalProgramming
{
    class Program
    {
        /// <summary>
        /// P1 - Printing the fibonacci series
        /// P2 - Checking the number is perfect number or not
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical programming");
            Console.WriteLine("Choose the program:");
            Console.WriteLine("1 - Fibonacci Series");
            Console.WriteLine("2 - Perfect Number");

            //Read choice from the user
            Console.WriteLine("Enter Your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                //creating object for Fibonacci series and invoke the method
                case 1:
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    fibonacciSeries.ReadInput();
                    break;

                //creating object for perfect number and invoke the method 
                case 2:
                    PerfectNumber perfectNumber = new PerfectNumber();
                    perfectNumber.ReadInput();
                    break;

                default:
                    break;
            }

            Console.Read();
        }
    }
}
