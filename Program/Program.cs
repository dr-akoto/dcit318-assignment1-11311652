using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "DCIT 318 Assignment 1";
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("=== DCIT 318: Assignment 1 ===");
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Grade Calculator");
                Console.WriteLine("2. Ticket Price Calculator");
                Console.WriteLine("3. Triangle Type Identifier");
                Console.WriteLine("4. Exit");
                Console.WriteLine("\n0. Return to Main Menu");
                Console.ResetColor();
                Console.Write("\nEnter your choice (0-4): ");
                string choice = Console.ReadLine() ?? string.Empty;

                switch (choice)
                {
                    case "0":
                        continue;
                    case "1":
                        RunGradeCalculator();
                        break;
                    case "2":
                        TicketPriceCalculator.Run();
                        break;
                    case "3":
                        TriangleTypeIdentifier.Run();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Press any key to try again...");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;
                }
            }



            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nThank you for using the Assignment 1 Application!");
            Console.ResetColor();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();



        }

        /// <summary>
        /// Runs the Grade Calculator loop.
        /// </summary>
        static void RunGradeCalculator()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("=== GRADE CALCULATOR ===");
                Console.WriteLine("(Enter '0' to return to main menu, 'start' to restart, 'end' to quit)");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Enter your numerical grade (0 - 100): ");
                Console.ResetColor();
                string input = Console.ReadLine() ?? string.Empty;

                if (input?.ToLower() == "start")
                {
                    continue;
                }
                if (input?.ToLower() == "end")
                {
                    return;
                }
                if (input == "0")
                {
                    return;
                }

                if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int grade))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.ResetColor();
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    continue;
                }

                string letterGrade = GetLetterGrade(grade, out ConsoleColor gradeColor);

                Console.ForegroundColor = gradeColor;
                Console.WriteLine($"\nYour letter grade is: {letterGrade}");
                Console.ResetColor();

                // Prompt to continue or end
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nPress Enter to calculate another grade, type '0' to return to main menu, or 'end' to quit.");
                Console.ResetColor();
                input = Console.ReadLine() ?? string.Empty;
                if (input?.ToLower() == "end")
                {
                    return;
                }
                if (input == "0")
                {
                    return;
                }
            }
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