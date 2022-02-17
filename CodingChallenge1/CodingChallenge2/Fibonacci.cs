using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge2
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            //Using the Fibonacci Sequence whose values do not exceed 4 million, find the sum of the even-valued terms


            
            int x = 1;
            int y = 2;

            for (int fs = 0; fs < 40; fs++)
            {
                y = (y + x);
                x = fs;   
            }
            Console.WriteLine(x);

        }
    }
}
