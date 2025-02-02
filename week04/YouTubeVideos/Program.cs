using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to store videos.
            List<Video> videos = new List<Video>();

            // Create Video 1 and add comments.
            Video video1 = new Video("Amazing Cat Compilation", "CatLover123", 300);
            video1.AddComment(new Comment("Alice", "So cute!"));
            video1.AddComment(new Comment("Bob", "I love these cats."));
            video1.AddComment(new Comment("Charlie", "Adorable videos."));
            videos.Add(video1);

            // Create Video 2 and add comments.
            Video video2 = new Video("Incredible Magic Trick", "MagicMike", 180);
            video2.AddComment(new Comment("Dave", "Wow, amazing!"));
            video2.AddComment(new Comment("Eve", "How did he do that?"));
            video2.AddComment(new Comment("Frank", "Mind-blowing performance."));
            videos.Add(video2);

            // Create Video 3 and add comments.
            Video video3 = new Video("Delicious Baking Tutorial", "BakingQueen", 600);
            video3.AddComment(new Comment("Grace", "Yummy, I need to try this recipe."));
            video3.AddComment(new Comment("Hank", "Baking is my passion!"));
            video3.AddComment(new Comment("Ivy", "Great tutorial, thanks!"));
            videos.Add(video3);

            // Iterate through the list and display information for each video.
            foreach (Video video in videos)
            {
                Console.WriteLine(video.DisplayVideoInfo());
                Console.WriteLine("------------------------------------------------");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
