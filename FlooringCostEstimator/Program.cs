using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlooringCostEstimator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This console application will estimate the cost of installing
             * new flooring. The user is prompted to input the length and 
             * width of the room in addition to the cost of the flooring
             * per square foot. Using declared constants, the cost for labor
             * and materials is calculated and then used to determine the
             * total cost for new flooring for the room.  
             */ 

            Console.WriteLine("Lisa's Flooring Cost Estimator:\n\n");

            //Declaring Constants
            const double installCost = 35.75;
            const double installRate = 40;

            //Declaring Variables
            int length;
            int width;
            int floorArea;

            //Prompt user for input
            Console.Write("Please enter floor length in feet: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter floor width in feet: ");
            width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the cost per square foot for selected flooring: $");
            double cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n               ++++++++++++++++++++++++\n");

            //Calculations
            floorArea = length * width;
            double totalFlrCost = floorArea * cost;
            double laborHrs = floorArea / installRate;
            double totalLaborCost = laborHrs * installCost;
            double totalCost = totalFlrCost + totalLaborCost;

            //Display results and final cost of floor installation
            Console.WriteLine("For a total floor size of " + floorArea + "sqft the flooring cost is: $" + totalFlrCost);
            Labor(laborHrs, totalLaborCost);
            Console.WriteLine("\nThe total finished cost for the new floor is: $" + totalCost.ToString("F"));

            Console.ReadLine();
        }
        /*I had a little bit of trouble formatting my decimal values to 
         *round them up.  With a little research, I found the ToString("F")
         *and decided to give it a try.  Visual Studio offered this snippet of 
         *code you see below.  It did the trick, but when I tried to apply this
         *bit to my flooring calculations, everything quit working correctly. 
         *My humble guess is that my usage of parameters/arguments was flawed, 
         *as that seemed to be the crux of the problem. Also, my code feels 
         *"clucky" and I know there is a better way to do the same thing.
         *I think I will take this program and try to approach it using 
         *what little I know of OOP at this point in my sparse spare time!
         */
        private static void Labor(double laborHrs, double totalLaborCost)
        {
            Console.WriteLine("It will take " + laborHrs.ToString("F") + " to install the floor at a cost of $" + totalLaborCost.ToString("F"));
        }
    }
}
