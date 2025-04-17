using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting to display videos...");
        List<Video> videos = new List<Video>();

        // First video
        Video video1 = new("Mastering C# for Beginners", "Nexlytech", 480);
        video1.AddComment(new Comment("Monson", "Crystal clear explanation, I'm finally getting it."));
        video1.AddComment(new Comment("Andrew", "Very structured content, this is gold."));
        video1.AddComment(new Comment("Beatrice", "Exactly what I needed to kickstart my coding journey."));
        videos.Add(video1);

        // Second video
        Video video2 = new("Getting Started with Python Projects", "Nexlytech", 720);
        video2.AddComment(new Comment("David", "The project examples were really practical. Loved it!"));
        video2.AddComment(new Comment("Juliet", "Your voice is calming and your teaching is top-notch."));
        video2.AddComment(new Comment("Kelvin", "Thanks for this! Can’t wait to build my first project."));
        videos.Add(video2);

        // Third video
        Video video3 = new("Understanding SQL with Real Examples", "Nexlytech", 395);
        video3.AddComment(new Comment("Carla", "The database breakdown was so simple to follow."));
        video3.AddComment(new Comment("Emeka", "The way you explained joins was top-tier."));
        video3.AddComment(new Comment("Zainab", "SQL now feels way less intimidating. Thank you!"));
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayVideo();
        }
    }
}
