// Lab 5
// Grading ID S2407

using System;
using System.Reflection.Metadata.Ecma335;
namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalTemp = 0;
            int loops = 0;
            while (true)
            {
                Console.WriteLine("Enter temperatures from -20 to 130 (enter 999 to stop)");
                string user_input = Console.ReadLine();
                double min = -20;
                double max = 130;
                if(user_input == "999")
                {
                    double avgtemp = totalTemp / loops;
                    Console.WriteLine("You have stopped the program\nYou enetered " + loops + " valid temperatures.");
                    Console.WriteLine("The mean temperature is " + Math.Round(avgtemp,2) + " degrees.");
                    break;
                }
                if (!double.TryParse(user_input, out double user))
                {
                    Console.WriteLine("You entered a non integer value");
                    continue;
                }
                if (user >= min && user <= max)
                {
                    totalTemp += user;
                    loops += 1;
                }
                else
                {
                    Console.WriteLine("Invalid temperature input");
                }
                    
               
            }
            
        }
    }
    
}