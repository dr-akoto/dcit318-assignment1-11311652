using System;

namespace GradeCalculator
{
    public class TicketPriceCalculator
    {
        public static void Run()
        {
            Console.Title = "Ticket Price Calculator";
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("=== TICKET PRICE CALCULATOR ===");
                Console.ResetColor();

                int age = PromptForAge();

                int price = (age <= 12 || age >= 65) ? 7 : 10;
                Console.ForegroundColor = (price == 7) ? ConsoleColor.Green : ConsoleColor.Yellow;
                Console.WriteLine($"\nYour ticket price is: GHC{price}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nPress Enter to calculate another ticket or type 'end' to exit.");
                Console.ResetColor();
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input) && input.Trim().ToLower() == "end")
                {
                    running = false;
                }
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nThank you for using the Ticket Price Calculator!");
            Console.ResetColor();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static int PromptForAge()
        {
            int age;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Enter your age: ");
                Console.ResetColor();
                string input = Console.ReadLine();

                if (!int.TryParse(input, out age) || age <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a valid positive age.");
                    Console.ResetColor();
                    continue;
                }
                break;
            }
            return age;
        }
    }
}