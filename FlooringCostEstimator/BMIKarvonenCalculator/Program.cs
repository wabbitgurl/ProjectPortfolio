using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIKarvonenCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring Constants
            const double poundsToKilograms = 0.45359237;
            const double inchesToMeters = 0.0254;
                             
            Console.WriteLine("~~~ BMI/Karvonen Calculator ~~~\n");

            /*The following block prompts the user for height in inches,
            *weight in pounds, age, and resting heart rate.*/
            Console.WriteLine("Please enter the following values for the client...\n");

            Console.Write("Height in Inches: ");
            int.TryParse(Console.ReadLine(), out int inches);
            Console.Write("Weight in Pounds: ");
            int.TryParse(Console.ReadLine(), out int weightInPounds);
            Console.Write("Client's Age: ");
            int.TryParse(Console.ReadLine(), out int age);
            Console.Write("Client's Resting HeartRate: ");
            int.TryParse(Console.ReadLine(), out int restingHR);
            
            //Converting pounds to kilograms and inches to meters
            double kg = weightInPounds * poundsToKilograms;
            double meters = inches * inchesToMeters;

            /*This section calculates the client's BMI and
             displays the results to the console. Using a
             series of nested if-else statements, the 
             application will determine whether a client 
             is underweight, overweight, normal, or obese.
             Additionally, I chose to use Math.Pow to obtain
             meters squared.
             */
            double bmi = kg / Math.Pow(meters,2);
            Console.Write("\n~~~ Results ~~~\n\n");
                if (bmi < 18.5) {
                    Console.Write("Your BMI is -- " + bmi.ToString("f") + " -- You are underweight!");

                } else if (bmi < 25) {
                    Console.Write("Your BMI is -- " + bmi.ToString("f") + " -- You are normal weight!");

                } else if (bmi < 30) {
                    Console.Write("Your BMI is -- " + bmi.ToString("f") + " -- You are overweight!");

                } else
                    Console.Write("Your BMI is -- " + bmi.ToString("f") + " -- You are Obese!");
            
            /*Lastly, this code block will calculate the
             target heart rate utilizing Karvonen's 
             Formula.  Setting this loop (i) to iterate 10 
             times with a starting intensity level of
             50%, each iteration increases the intensity
             level by 5% and displays the target HR and
             max heart rate for the percentage of 
             exercise intensity to the console.
             */
            double intensity = .50;
            Console.Write("\n\n~~~ Exercise Intensity Heart Rates ~~~ \n\n");
                for (int i = 0; i < 10; i++)
                {
                    int targetHR = (int)(((220 - age - restingHR) * intensity) + restingHR);
                    Console.WriteLine("Intensity: " + intensity.ToString("p0") + "   --   " + "Max Heart Rate: " + targetHR);
                    intensity += .05;
                } 
            
            Console.ReadLine();

        }
    }
}
