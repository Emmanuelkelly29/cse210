using System;
using System.Threading;

class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int duration) : base(duration, "Breathing", "Let this exercise help ease your mind as you engage in calming breath cycles") {}

    public void StartBreathing()
    {
        StartMessage();
        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            Console.Write("Inhale deeply...");
            PauseWithAnimation(3);
            elapsedTime += 3;

            Console.Write("Now exhale gently...");
            PauseWithAnimation(3);
            elapsedTime += 3;
        }
        EndMessage("Breathing");
    }
}
