using System;

namespace LogicalProgramming
{
    class Program
    {
        /// <summary>
        /// P1 - Printing the fibonacci series
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical programming");
            Console.WriteLine("Choose the program:");
            Console.WriteLine("1 - Fibonacci Series");

            //Read choice from the user
            Console.WriteLine("Enter Your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    fibonacciSeries.ReadInput();
                    break;

                default:
                    break;
            }

            Console.Read();
        }
    }
}
