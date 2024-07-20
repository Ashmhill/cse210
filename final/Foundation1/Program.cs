using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create videos and add them to the list
        var videos = new List<Video>
        {
            new Video("How to Cook Pasta", "Chef John", 600),
            new Video("Top 10 Travel Destinations", "Traveler Mike", 900),
            new Video("Learn C# in 10 Minutes", "CodeAcademy", 600),
            new Video("The Future of AI", "Tech Guru", 1200)
        };

        // Add comments to videos
        videos[0].AddComment(new Comment("Alice", "Great recipe!"));
        videos[0].AddComment(new Comment("Bob", "Thanks for the tips!"));
        videos[0].AddComment(new Comment("Charlie", "Yummy!"));

        videos[1].AddComment(new Comment("Dave", "Can't wait to visit these places."));
        videos[1].AddComment(new Comment("Eve", "Very informative!"));
        videos[1].AddComment(new Comment("Frank", "Thanks for sharing!"));

        videos[2].AddComment(new Comment("Grace", "Very helpful tutorial."));
        videos[2].AddComment(new Comment("Heidi", "Clear and concise."));
        videos[2].AddComment(new Comment("Ivan", "Loved it!"));

        videos[3].AddComment(new Comment("Judy", "Very insightful!"));
        videos[3].AddComment(new Comment("Ken", "AI is fascinating."));
        videos[3].AddComment(new Comment("Laura", "Looking forward to more videos on this topic."));

        // Display video details and comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine(new string('=', 40));
        }
    }
}
