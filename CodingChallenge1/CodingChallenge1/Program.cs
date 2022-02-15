using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //variables declared
            int sum = 0;
            int sum1 = 0;
            int answer = 0;



            //writing a for loop to count natural numbers by 3's from 0 to 1000. 
            for (int i = 3; i < 1000; i += 3)//attempting to iterate by 3
            {
                //Console.WriteLine(i); placed to test the iteration for count by 3
                sum += i;
            }
            // Console.WriteLine($"{sum}");//testing sum function

            //for loop to iterate by 5's. Counting natural numbers from 0 - 1000 by 5's.
            for (int x = 0; x < 1000; x += 5)
            {
                // Console.WriteLine(x);testing iteration
                sum1 += x;
            }
            //Console.WriteLine(sum1); testing the sum function


            answer = sum + sum1;
            Console.WriteLine($"The answer is: {answer}.");//string interpolation to display answer (sum of sum + sum1)
        }
    }
}
