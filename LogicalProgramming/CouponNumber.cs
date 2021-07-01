using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming
{
    class CouponNumber
    {
        private const int TOTAL_COUPON = 10;
        public static void GenerateCoupon()
        {
            //local variable to check number of coupons and array to store distinct coupons
            int numOfCoupon = 0;
            int iter = 0;
            int noRepeat = 1;
            int generateTime = 0;
            int[] coupon = new int[10];

            //creating object for random class
            Random random = new Random();

            //check till total number of distinct coupon is received 
            while (numOfCoupon < TOTAL_COUPON)
            {
                noRepeat = 1;
                iter = 0;
                int tempCoupon = random.Next(1,12);
                Console.WriteLine(""+tempCoupon);

                while(iter <= numOfCoupon)
                {
                    //check distinct or not
                    if(coupon[iter]==tempCoupon)
                    {
                        noRepeat = 0;
                        break;
                    }
                    iter++;
                }
                generateTime++;
                if(noRepeat==1)
                {
                    coupon[numOfCoupon] = tempCoupon;
                    numOfCoupon++;
                }
            }
            //displays random number needed to generate 10 distinct coupon
            Console.WriteLine("Number of Time required to generate 10 distict coupon:"+generateTime);

            //displays the distinct coupon
            Console.WriteLine("The Distinct 10 coupons are :");
            foreach ( int  i  in  coupon)
                {
                    Console.WriteLine(i);
                }
        }
    }
}
