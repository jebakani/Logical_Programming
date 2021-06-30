using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class PrimeNumberSeries
    {
        public void ReadInput()
        {
            Console.WriteLine("Welcome to Prime Number Series");
            Console.WriteLine("Enter the number:");

            //Read input from user
            int number = Convert.ToInt32(Console.ReadLine());
            FindPrimeSeries(number);
        }

        private void FindPrimeSeries(int num)
        {
            //local variable to check prime or not
            int isprime;

            Console.WriteLine("The Prime number between 1 to {0} are",num);
            for(int iter=2;iter<=num;iter++)
            {
                isprime = 1;

                //Checking the below condition for n number of times 
                for (int primeTester=2;primeTester<=Math.Sqrt(iter);primeTester++)
                {
                    //check whether the number is divisible by any other number
                    if(iter%primeTester==0)
                    {
                        isprime = 0;
                        break;
                    }
                }

                //if it is not divisible by any other number then print as prime number
                if(isprime==1)
                {
                    Console.WriteLine("{0}",iter);
                }
            }
        }
    }
}
