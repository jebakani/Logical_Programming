using System;

namespace LogicalProgramming
{
    class Program
    {
        /// <summary>
        /// P1 - Printing the fibonacci series
        /// P2 - Checking the number is perfect number or not
        /// P3 - Printing the prime number series between  to N
        /// P4 - Reversing the number
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical programming");
            Console.WriteLine("Choose the program:");
            Console.WriteLine("1 - Fibonacci Series");
            Console.WriteLine("2 - Perfect Number");
            Console.WriteLine("3 - Prime Number Series");
            Console.WriteLine("4 - Reverse the number");

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

                //creating object for prime number and invoke the method 
                case 3:
                    PrimeNumberSeries prime = new PrimeNumberSeries();
                    prime.ReadInput();
                    break;

                //creating object for Reverse a number and calling the method 
                case 4:
                    ReverseNumber reverse = new ReverseNumber();
                    reverse.ReadInput();
                    break;

                default:
                    break;
            }

            Console.Read();
        }
    }
}
