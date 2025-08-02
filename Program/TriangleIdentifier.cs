using System;

namespace GradeCalculator
{
    public class TriangleTypeIdentifier
    {
        public static void Run()
        {
            Console.Title = "Triangle Type Identifier";
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("=== TRIANGLE TYPE IDENTIFIER ===");
                Console.ResetColor();

                double[] sides = new double[3];
                for (int i = 0; i < 3; i++)
                {
                    sides[i] = PromptForSide(i + 1);
                }

                if (!IsValidTriangle(sides[0], sides[1], sides[2]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nThe entered sides do not form a valid triangle.");
                    Console.ResetColor();
                }
                else
                {
                    string type = GetTriangleType(sides[0], sides[1], sides[2], out ConsoleColor color);
                    Console.ForegroundColor = color;
                    Console.WriteLine($"\nThe triangle is: {type}");
                    Console.ResetColor();
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nPress Enter to check another triangle or type 'end' to exit.");
                Console.ResetColor();
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input) && input.Trim().ToLower() == "end")
                {
                    running = false;
                }
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nThank you for using the Triangle Type Identifier!");
            Console.ResetColor();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static double PromptForSide(int sideNumber)
        {
            double side;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"Enter length of side {sideNumber}: ");
                Console.ResetColor();
                string input = Console.ReadLine();

                if (!double.TryParse(input, out side) || side <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                    Console.ResetColor();
                    continue;
                }
                break;
            }
            return side;
        }

        static bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        static string GetTriangleType(double a, double b, double c, out ConsoleColor color)
        {
            if (a == b && b == c)
            {
                color = ConsoleColor.Green;
                return "Equilateral";
            }
            if (a == b || b == c || a == c)
            {
                color = ConsoleColor.Yellow;
                return "Isosceles";
            }
            color = ConsoleColor.Cyan;
            return "Scalene";
        }
    }
}