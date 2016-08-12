using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0302_081116
{
    class Program
    {
        static void Main(string[] args)
        {
            /********************************************************************************
             * In the United States, a car's fuel economy is measured in miles per gallon,  *
             * or MPG. This program uses the following formula to calculate a car's MPG:    *
             *                                                                              *
             *                   MPG = Miles driven / Gallons of gas used                   *
             *                                                                              *         
             * This program lets the user enter the number of miles he or she has driven    * 
             * the gallons of gas used. The program will calculate and display the cars's   *
             * MPG.                                                                         *
             ********************************************************************************/
                        
            // Get the miles driven and assign it to 
            // the gallons variable.
            Console.Write("Enter the number of miles driven: ");
            var miles = int.Parse(Console.ReadLine());

            // Get the gallons used and assign it to 
            // the gallons variable.
            Console.Write("Enter the number of gallons used: ");
            var gallons = int.Parse(Console.ReadLine());

            // Calculate MPG.
            var mpg = miles / gallons;

            // Display the MPG
            Console.WriteLine("Your car's MPG: " + mpg);
            Console.ReadLine();
        }
    }
}
