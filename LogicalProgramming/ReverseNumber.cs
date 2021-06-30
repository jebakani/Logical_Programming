using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class ReverseNumber
    {
        public void ReadInput()
        {
            Console.WriteLine("Welcome to Reverse a number");
            Console.WriteLine("Enter the number to be reversed:");

            //Read input from user
            int number = Convert.ToInt32(Console.ReadLine());
            ReversingNumber(number);
        }

        private static void ReversingNumber(int num)
        {
            //local variable to store last digit and result value
            int result = 0;
            int rev;

            //checks the number is not equal to zero 
            while(num!=0)
            {   
                //returns last digit 
                rev = num % 10;
                //multiply with 10 and add last digit in each iteration
                result = (result * 10) + rev;
                //remove the last digit
                num /= 10;

            }
            Console.WriteLine("The Number after reversing:"+result);
        }

    }
}
