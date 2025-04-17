using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : MindfulnessActivity
{
    private static readonly List<string> prompts = new List<string>
    {
        "Who are some individuals you appreciate?",
        "What abilities do you value most in yourself?",
        "Who have you helped recently?",
        "When have you felt most at peace this month?",
        "Who inspires you as a personal hero?"
    };

    public ListingActivity(int duration) : base(duration, "Listing", "This activity will help you reflect on the positive aspects of your life.") { }

    public void StartListing()
    {
        StartMessage();

        Random rand = new Random();
        string selectedPrompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine($"\n--- {selectedPrompt} ---");
        PauseWithAnimation(5);

        List<string> responses = new List<string>();

        Console.WriteLine("\nStart listing! Type as many responses as you can:");

        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            Console.Write("> ");
            responses.Add(Console.ReadLine());
            elapsedTime += 2;
        }

        Console.WriteLine($"\nYou listed {responses.Count} items!");
        EndMessage("Listing");
    }
}
