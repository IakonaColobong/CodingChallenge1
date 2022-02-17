using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenDigitFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            /*          
          
           The Fibonacci sequence is defined by the recurrence relation:

           Fn = Fn−1 + Fn−2, where F1 = 1, F2 = 1, F3 = 2, .... and F12 = 144.F12 is the first term to contain three digits.

           What is the index of the first term in the Fibonacci sequence to contain 10 digits ?


            thoughts: take previous iteration sequence (minus sum) and add values to an array then select from array
           */

            int x = 1;
            int y = 2;
            int newSum = 0;



            //while (newSum <= 1000050000)
            //{
            //    newSum = x + y;

            //    x = y;
            //    y = newSum;

            //}
            List<int> sequence = new List<int>();
            //int[] sequence = new int[] { };
            for (int i = 0; i < 400000; i++)
            {
                newSum = x + y;
                x = y;


                sequence.Add(newSum);
            }
            
            Console.WriteLine(sequence);//generates generic list only FIX IT

        }
    }
}
