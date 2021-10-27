/*using System;
using System.Collections.Generic;
using System.Text;

namespace day6
{
    class reverse_num
    {
        public static void Main(string[] args)
        {
            int N, rev = 0, rem = 0;
            Console.Write("Enter a Number = ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" number before reverse = " + N);

            while (N > 0)
            {
                rem = N % 10;
                N = N / 10;
                rev = rev * 10 + rem;

            }
            Console.WriteLine(" number after reverse =" + rev);
        }
    }
}
*/