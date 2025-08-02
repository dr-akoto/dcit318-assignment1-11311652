using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Grade Calculator";
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("=== GRADE CALCULATOR ===");
                Console.ResetColor();

                int grade = PromptForGrade();

                string letterGrade = GetLetterGrade(grade, out ConsoleColor gradeColor);

                Console.ForegroundColor = gradeColor;
                Console.WriteLine($"\nYour letter grade is: {letterGrade}");
                Console.ResetColor();

                // Prompt to continue or end
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nPress Enter to calculate another grade or type 'end' to exit.");
                Console.ResetColor();
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input) && input.Trim().ToLower() == "end")
                {
                    running = false;
                }
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nThank you for using the Grade Calculator!");
            Console.ResetColor();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Prompts the user for a valid grade between 0 and 100.
        /// </summary>
        /// <returns>An integer grade.</returns>
        static int PromptForGrade()
        {
            int grade;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Enter your numerical grade (0 - 100): ");
                Console.ResetColor();
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Input cannot be empty. Please enter a number between 0 and 100.");
                    Console.ResetColor();
                    continue;
                }

                if (!int.TryParse(input, out grade))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.ResetColor();
                    continue;
                }

                if (grade < 0 || grade > 100)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Grade must be between 0 and 100.");
                    Console.ResetColor();
                    continue;
                }

                break;
            }
            return grade;
        }

        /// <summary>
        /// Returns the letter grade and its associated color for a given numerical grade.
        /// </summary>
        static string GetLetterGrade(int grade, out ConsoleColor color)
        {
            if (grade >= 90)
            {
                color = ConsoleColor.Green;
                return "A";
            }
            if (grade >= 80)
            {
                color = ConsoleColor.Cyan;
                return "B";
            }
            if (grade >= 70)
            {
                color = ConsoleColor.Yellow;
                return "C";
            }
            if (grade >= 60)
            {
                color = ConsoleColor.Magenta;
                return "D";
            }
            color = ConsoleColor.Red;
            return "F";
        }
    }
}