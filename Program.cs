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
            Console.WriteLine("Please enter your grade for ISM 3400");

            try
            {
                string input = Console.ReadLine();
               decimal grade = decimal.Parse(input);
                if (grade >= 98)
                    Console.WriteLine("Your Grade is an A+");
                else if ((grade >= 92) && (grade < 97))
                    Console.WriteLine("Your Grade is an A");
                else if ((grade >= 90) && (grade < 92))
                    Console.WriteLine("Your Grade is an A-");
                else if ((grade >= 88) && (grade < 90))
                    Console.WriteLine("Your Grade is an B+");
                else if ((grade >= 82) && (grade < 88))
                    Console.WriteLine("Your Grade is an B");
                else if ((grade >= 80) && (grade < 82))
                    Console.WriteLine("Your Grade is an B-");
                else if ((grade >= 78) && (grade < 80))
                    Console.WriteLine("Your Grade is an C+");
                else if ((grade >= 72) && (grade < 78))
                    Console.WriteLine("Your Grade is an C");
                else if ((grade >= 70) && (grade < 72))
                    Console.WriteLine("Your Grade is an C-");
                else if ((grade >= 68) && (grade < 70))
                    Console.WriteLine("Your Grade is an D+");
                else if ((grade >= 62) && (grade < 68))
                    Console.WriteLine("Your Grade is an D");
                else if ((grade >= 60) && (grade < 62))
                    Console.WriteLine("Your Grade is an D-");
                else if (grade < 60)
                    Console.WriteLine("F");
                else Console.WriteLine("Please Enter a valid grade");
            }
            catch
            {
                Console.WriteLine("Please Enter a valid grade");
            }
        }
    }
}
