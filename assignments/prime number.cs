/*using System;
using System.Collections.Generic;
using System.Text;

namespace day6
{
    class prime_number
    {
        public static void Main(string[] args)
        {
            int n, i, m = 0, sum = 0;
            Console.Write("Enter the Number to check Prime = ");
            n = Convert.ToInt32(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime Number.");
                    sum = 1;
                    break;
                }
            }
            if (sum == 0)
                Console.Write("Number is Prime Number.");
        }
    }
}
*/