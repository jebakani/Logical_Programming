using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class PerfectNumber
    {
        public void ReadInput()
        {
            Console.WriteLine("Welcome to Perfect Number");
            Console.WriteLine("Enter the number:");

            //Read input from user
            int number = Convert.ToInt32(Console.ReadLine());
            CheckForPerfect(number);
        }

        //Check whether the number is perfect or not
        private static void CheckForPerfect(int num)
        {
            int sum = 0;
            //Add the factor of number till it equal to number
            for (int perf = 1; perf <= num / 2; perf++)
            {
                if (num % perf == 0)
                {
                    sum += perf;
                }

            }

            //check whether sum is equal to number
            if (sum == num)
            {
                Console.WriteLine("{0} is the perfect number", num);
            }
            else
            {
                Console.WriteLine("{0} is the not perfect number with sum of factor {1}", num, sum);
            }
        }
    }
}
