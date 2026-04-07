using System;

namespace GradeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Grade Checker");

            Console.Write("Enter your exam score (0-100): ");
            string input = Console.ReadLine();

            int score = Convert.ToInt32(input);

            if (score >= 75)
            {
                Console.WriteLine("\nResult: PASSED");
                Console.WriteLine("Great job! Keep up the hard work.");
            }
            else
            {
                Console.WriteLine("\nResult: FAILED");
                Console.WriteLine("Don't give up! Review the materials and try again.");
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}