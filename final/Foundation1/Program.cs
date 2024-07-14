// Program.cs
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create 3-4 videos
        Video video1 = new Video("How to Cook Pasta", "Chef John", 600);
        Video video2 = new Video("Python Programming Tutorial", "Tech Guru", 1200);
        Video video3 = new Video("Travel Vlog: Japan", "Wanderlust", 900);

        // Add 3-4 comments to each video
        video1.AddComment(new Comment("Alice", "Great recipe!"));
        video1.AddComment(new Comment("Bob", "Tried it and loved it!"));
        video1.AddComment(new Comment("Charlie", "Can't wait to try this."));

        video2.AddComment(new Comment("David", "Very informative."));
        video2.AddComment(new Comment("Eva", "Helped me a lot, thanks!"));
        video2.AddComment(new Comment("Frank", "Can you make a tutorial on Django?"));

        video3.AddComment(new Comment("Grace", "Beautiful footage!"));
        video3.AddComment(new Comment("Hank", "Japan is on my bucket list."));
        video3.AddComment(new Comment("Ivy", "Loved the video!"));

        // Put videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Iterate through the list of videos and display information
        foreach (var video in videos)
        {
            Console.WriteLine(video);
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"  {comment}");
            }
            Console.WriteLine();
        }
    }
}
