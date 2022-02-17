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
            int sum = 0;
            int newSum = 0;

            while (newSum <= 4000000) //declaring condition for while loop - this will continue until it reaches 400000 without exceeding
            {
                newSum = x + y; //declaring newSum to be equal to the sum of x+y
                if (newSum % 2 == 0)//checks if the newSum divided by 2 is equal to zero
                {
                    sum += newSum;//if the remainder is zero, variable sum will have newSum added to it
                }//end if

                x = y;//y takes on the value y had during THIS iteration
                y = newSum;//y takes on newSum's value
          
                /*Notes made for my own visualization:  
                 * first iteration --
                 * 1+2 = newSum (3); 3 divided by 2 is NOT equal to zero exit loop
                 * x (formerly 1) becomes what y(formerly 2) was so x is now equal to 3
                 * y takes whatever value newSum carried - 3
                 * 
                 * second iteration
                 * 2(because x took y's value) + 3 (because y took newSum's value) = 5
                 * 5 / 2 is NOT zero so exit loop. 
                 * x is now equal to 3 (because Y was equal to 3)
                 * y is now equal to 5 (because newSum was 5)
                 
             */
            }
            Console.WriteLine(sum);
        }
    }
}
