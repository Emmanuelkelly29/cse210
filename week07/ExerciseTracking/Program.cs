using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        while (true)
        {
            Console.WriteLine("\nChoose an activity to add:");
            Console.WriteLine("1. Running");
            Console.WriteLine("2. Cycling");
            Console.WriteLine("3. Swimming");
            Console.WriteLine("4. Exit and Display Summaries");

            string choice = Console.ReadLine();

            if (choice == "4")
            {
                break;
            }

            Console.Write("Enter the date (yyyy-mm-dd): ");
            DateTime date;
            while (!DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.Write("Invalid date format. Please enter the date (yyyy-mm-dd): ");
            }

            Console.Write("Enter the duration (in minutes): ");
            int length;
            while (!int.TryParse(Console.ReadLine(), out length) || length <= 0)
            {
                Console.Write("Invalid input. Please enter a positive number for the duration: ");
            }

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the distance in kilometers: ");
                    double runningDistance;
                    while (!double.TryParse(Console.ReadLine(), out runningDistance) || runningDistance <= 0)
                    {
                        Console.Write("Invalid input. Please enter a positive number for the distance: ");
                    }
                    activities.Add(new Running(date, length, runningDistance));
                    break;
                case "2":
                    Console.Write("Enter the speed in kilometers per hour: ");
                    double cyclingSpeed;
                    while (!double.TryParse(Console.ReadLine(), out cyclingSpeed) || cyclingSpeed <= 0)
                    {
                        Console.Write("Invalid input. Please enter a positive number for the speed: ");
                    }
                    activities.Add(new Cycling(date, length, cyclingSpeed));
                    break;
                case "3":
                    Console.Write("Enter the number of laps: ");
                    int swimmingLaps;
                    while (!int.TryParse(Console.ReadLine(), out swimmingLaps) || swimmingLaps <= 0)
                    {
                        Console.Write("Invalid input. Please enter a positive number for the laps: ");
                    }
                    activities.Add(new Swimming(date, length, swimmingLaps));
                    break;
                default:
                    Console.WriteLine("Invalid choice, try again.");
                    break;
            }
        }

        Console.WriteLine("\nActivity Summaries:");
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
