using System;

namespace GradeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Advanced Grade Checker");

            Console.Write("Enter your exam score (0-100): ");
            string input = Console.ReadLine();
            int score = Convert.ToInt32(input);

            if (score >= 90)
            {
                Console.WriteLine("\nResult: PASSED WITH DISTINCTION!");
                Console.WriteLine("Excellent performance! You're at the top of the class.");
            }
            else if (score >= 75)
            {
                Console.WriteLine("\nResult: PASSED");
                Console.WriteLine("Good job! You met the requirements.");
            }
            else
            {
                Console.WriteLine("\nResult: FAILED");
                Console.WriteLine("Please schedule a consultation with the instructor.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}