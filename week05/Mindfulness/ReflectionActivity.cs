using System;
using System.Collections.Generic;
using System.Threading;

class ReflectionActivity : MindfulnessActivity
{
    private static readonly List<string> prompts = new List<string>
    {
        "Recall a time when you stood up for someone.",
        "Think of a moment when you overcame a challenge.",
        "Remember an instance where you helped someone.",
        "Consider a situation when you prioritized others over yourself.",
    };

    private static readonly List<string> questions = new List<string>
    {
        "Why was this experience significant to you?",
        "Have you experienced something similar before?",
        "What was your first step in this situation?",
        "How did you feel once it was complete?",
        "What made this moment unique from others?",
        "What stands out to you about this experience?",
        "What can you learn from this moment and apply elsewhere?",
        "What insights about yourself did you gain?",
        "How can this experience guide your future actions?",
    };

    public ReflectionActivity(int duration) : base(duration, "Reflection", "This activity helps you reflect on moments of resilience and strength.") {}

    public void StartReflection()
    {
        StartMessage();
        Random rand = new Random();
        string selectedPrompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine($"\n--- {selectedPrompt} ---");
        PauseWithAnimation(5);

        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            string question = questions[rand.Next(questions.Count)];
            Console.WriteLine($"\n{question}");
            PauseWithAnimation(5);
            elapsedTime += 5;
        }
        EndMessage("Reflection");
    }
}
