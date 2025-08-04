using System;

namespace GradeCalculator
{
    public static class TriangleTypeIdentifier
    {
        public static void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("=== TRIANGLE TYPE IDENTIFIER ===");
                Console.WriteLine("(Enter '0' to return to main menu, 'start' to restart, 'end' to quit)");
                Console.ResetColor();

                Console.Write("Enter the first side of the triangle: ");
                string input = Console.ReadLine() ?? string.Empty;

                if (input.ToLower() == "start")
                {
                    continue;
                }
                if (input.ToLower() == "end")
                {
                    return;
                }
                if (input == "0")
                {
                    return;
                }

                if (!double.TryParse(input, out double a))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.ResetColor();
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    continue;
                }

                Console.Write("Enter the second side of the triangle: ");
                input = Console.ReadLine() ?? string.Empty;
                if (!double.TryParse(input, out double b))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.ResetColor();
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    continue;
                }

                Console.Write("Enter the third side of the triangle: ");
                input = Console.ReadLine() ?? string.Empty;
                if (!double.TryParse(input, out double c))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    Console.ResetColor();
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                    continue;
                }

                string triangleType = IdentifyTriangle(a, b, c);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\nThis is a {triangleType} triangle.");
                Console.ResetColor();

                Console.WriteLine("\nPress Enter for another triangle, '0' for main menu, 'start' to restart, or 'end' to quit");
                input = Console.ReadLine() ?? string.Empty;
                if (input.ToLower() == "end")
                {
                    return;
                }
                if (input == "0")
                {
                    return;
                }
                if (input.ToLower() == "start")
                {
                    continue;
                }
            }
        }

        private static string IdentifyTriangle(double a, double b, double c)
        {
            if (a == b && b == c) return "Equilateral";
            if (a == b || b == c || a == c) return "Isosceles";
            return "Scalene";
        }
    }
}
