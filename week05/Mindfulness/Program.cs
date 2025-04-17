using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. View Saved Sessions");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            if (choice == "5") break;
            if (choice == "4")
            {
                ViewLogs();
                continue;
            }

            Console.Write("Enter duration (in seconds): ");
            int duration;
            while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number:");
            }

            switch (choice)
            {
                case "1":
                    new BreathingActivity(duration).StartBreathing();
                    break;
                case "2":
                    new ReflectionActivity(duration).StartReflection();
                    break;
                case "3":
                    new ListingActivity(duration).StartListing();
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }
        Console.WriteLine("Goodbye!");
    }

    static void ViewLogs()
    {
        Console.Clear();
        Console.WriteLine("📝 Past Mindfulness Sessions:");

        if (File.Exists("mindfulness_log.txt"))
        {
            string logs = File.ReadAllText("mindfulness_log.txt");
            Console.WriteLine(logs);
        }
        else
        {
            Console.WriteLine("No past sessions found.");
        }

        Console.WriteLine("\nPress Enter to return to the menu...");
        Console.ReadLine();
    }
}
