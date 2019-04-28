using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeibnizPICalculation
{
    class Program
    {
        static void Main(string[] args)
        {

            /*This console application prompts the user to enter
              the number of times to run the Leibniz formula to
              calculate PI.  As a convergence sequence, it takes
              millions of iterations to obtain the true value
              of PI.
              
              This is not some of my better work!  I feel 
              the code is herky-jerky and the output, though 
              formatted to 10 decimal places, is off and I 
              cannot find it!  Tis a hot mess, but I have been 
              working on it longer than I should and it's time
              to turn this in and take my lumps!
              */

            Console.WriteLine("Welcome to Lisa's Leibniz Calculator for PI!\n");

            /*Declaring variables
            (Why do I feel like I cheated setting numerator & denominator values?).
            */
            double iterations;
            double pi = 1;
            double numerator = 1;
            double denom = 3;
            double result = 1;

            //Prompting the user to enter the number of iterations desired
            Console.WriteLine("Please enter the number of times to run this calculation. ");
            Console.Write("Enter a value greater than 1 million: ");
            iterations = Convert.ToDouble(Console.ReadLine());

            //Intiate a while-loop to check for proper user input
            while (iterations < 1e6)
            {
                Console.Write("Please enter a value greater than 1 million: ");
                iterations = Convert.ToDouble(Console.ReadLine());
            }
            for (double i = 1; i < iterations; i++)
            {
                numerator = numerator * -1;
                result = result + numerator * (double)1 / denom;
                pi = result * 4;
                denom += 2;

                if (i == 10 || i == 1000 || i == 100000 || i == 500000 || i == 1000000 || i == 2000000)
                {
                    Console.WriteLine($"The value for PI after {i} iterations is {pi:N10}", pi);
                }
            }
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            Console.ReadLine();
        }
    }
}


