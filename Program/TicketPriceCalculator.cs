using System;

namespace GradeCalculator
{
    public static class TicketPriceCalculator
    {
        public static void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("=== TICKET PRICE CALCULATOR ===");
                Console.WriteLine("(Enter '0' to return to main menu, 'start' to restart, 'end' to quit)");
                Console.ResetColor();

                Console.Write("Enter age: ");
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

                if (!int.TryParse(input, out int age))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid age. Press any key to try again...");
                    Console.ResetColor();
                    Console.ReadKey();
                    continue;
                }

                decimal price = CalculatePrice(age);
                Console.WriteLine($"Ticket price: ${price:F2}");

                Console.WriteLine("\nPress Enter to calculate another ticket, '0' for main menu, 'start' to restart, or 'end' to quit");
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

        private static decimal CalculatePrice(int age)
        {
            if (age < 5) return 0;
            if (age < 13) return 10;
            if (age < 60) return 20;
            return 15;
        }
    }
}