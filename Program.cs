using System;

namespace TaleOfTwoBankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ananya's money>> ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fatima's money>> ");
            int f = Convert.ToInt32(Console.ReadLine());

            bool run = true;

            //count a should keep track of how many a's and f's var1 is made of
            int[] count_v1 = { 1, 0 };

            //count f should keep track of how many a's and f's var2 it is made of
            int[] count_v2 = { 0, 1 };

            //where it is count_x is [a,f]

            int var1 = a;
            int var2 = f;

            while (run)
            {
                if( var1==var2 || var1<1 || var2<1)
                {
                    run = false;
                    Console.WriteLine("Smallest value found = " + var1);
                    Console.WriteLine(String.Format("Ananya multiplier: {0}\n Fatima multiplier: {1}", count_v1[0], count_v1[1]));
                    Console.WriteLine(String.Format("{0} x {1} + {2} x {3} = {4}", a, count_v1[0], f, count_v1[1], var1));
                    Console.ReadLine();
                }
                else if (var2 < var1)
                {
                    var1 = var1 -var2;
                    count_v1[0] = count_v1[0] - count_v2[0];
                    count_v1[1] = count_v1[1] - count_v2[1];
                }
                else if (var1 < var2)
                {
                    var2 = var2 - var1;
                    count_v2[0] = count_v2[0] - count_v1[0];
                    count_v2[1] = count_v2[1] - count_v1[1];
                }

            }
        }
    }
}
