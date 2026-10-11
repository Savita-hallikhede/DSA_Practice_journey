using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day2
{
    //Write a program to find the LCM of two numbers.

    internal class LCM_Finding
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number 1:");
            int num1 = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Enter the number 2:");
            int num2 = Convert.ToInt32(Console.ReadLine()); 

            int lcm = 1;
            for(int i=1; i<=num1*num2; i++) 
            {
                if(i%num1==0 && i%num2==0)
                {
                    lcm = i;
                    break;
                }
            }
            Console.WriteLine("Least Common value:" + lcm);
        }
    }
}
/*
 Perspective 1 — i % 2

This means:

Can 2 divide i completely?

For example:

i = 6

6 % 2 = 0

So 2 is a divisor of 6. ✅

At the same time, 6 is a multiple of 2. ✅

So when:

i % 2 == 0

you can say both:

2 is a divisor/factor of i
i is a multiple of 2
The important relationship

If:

i % 2 == 0

then:

2 → divisor
i → multiple
So for:

6 % 2 == 0

you can look at it in two ways:

6 ÷ 2 = 3
↑   ↑
multiple  divisor

OR:

2 × 3 = 6
↑       ↑
divisor multiple
*/
