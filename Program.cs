/* 
Author: Juliana Dunlap
Date: 1/30/2020
Project: Week 2 Deliverable 2.1 Conditional Statements
*/
using System;

namespace Deliverable2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt user for grade entry 
            Console.WriteLine("Please enter your grade for ISM 4300");

            try
            { //declare variable for the inputted grade as a decimal
                string input = Console.ReadLine();
               decimal grade = decimal.Parse(input);

                // A grade 98.0 and better is an A+
                if ((grade >= 98) && (grade <=100))
                    Console.WriteLine("Your Grade is an A+");

                // A grade between 92.0 and 97.0 is an A
                else if ((grade >= 92) && (grade < 97))
                    Console.WriteLine("Your Grade is an A");

                // A grade between 90.0 and 92.0 is an A-
                else if ((grade >= 90) && (grade < 92))
                    Console.WriteLine("Your Grade is an A-");

                // A grade between 88.0 and 90.0 is a B+
                else if ((grade >= 88) && (grade < 90))
                    Console.WriteLine("Your Grade is an B+");

                // A grade between 82.0 and 88.0 is a B
                else if ((grade >= 82) && (grade < 88))
                    Console.WriteLine("Your Grade is an B");

                // A grade between 80.0 and 82.0 is a B-
                else if ((grade >= 80) && (grade < 82))
                    Console.WriteLine("Your Grade is an B-");

                // A grade between 78.0 and 80.0 is a C+
                else if ((grade >= 78) && (grade < 80))
                    Console.WriteLine("Your Grade is an C+");

                // A grade between 72.0 and 78.0 is a C
                else if ((grade >= 72) && (grade < 78))
                    Console.WriteLine("Your Grade is an C");

                // A grade between 70.0 and 72.0 is a C-
                else if ((grade >= 70) && (grade < 72))
                    Console.WriteLine("Your Grade is an C-");

                // A grade between 68.0 and 70.0 is a D+
                else if ((grade >= 68) && (grade < 70))
                    Console.WriteLine("Your Grade is an D+");

                // A grade between 62.0 and 68.0 is a D
                else if ((grade >= 62) && (grade < 68))
                    Console.WriteLine("Your Grade is an D");

                // A grade between 60.0 and 62.0 is a D-
                else if ((grade >= 60) && (grade < 62))
                    Console.WriteLine("Your Grade is an D-");

                // A grade 60.0 or worse is a F
                else if ((grade < 60) && (grade >= 0))
                    Console.WriteLine("F");

                // A grade entered that does not fall between the letter grade designations is an invalid grade
                else Console.WriteLine("Please Enter a valid grade");

            }
            catch
            { // An invalid grade will tell the user to enter a valid grade 
                Console.WriteLine("Please Enter a valid grade");

            }
        }
    }
}
