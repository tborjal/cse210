using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("Video 1", "Author 1", 60);
        v1.Comments.Add(new Comment("Commenter 1", "Text 1"));
        v1.Comments.Add(new Comment("Commenter 2", "Text 2"));
        v1.Comments.Add(new Comment("Commenter 3", "Text 3"));
        v1.Comments.Add(new Comment("Commenter 4", "Text 4"));

        Video v2 = new Video("Video 2", "Author 2", 90);
        v2.Comments.Add(new Comment("Commenter 5", "Text 5"));
        v2.Comments.Add(new Comment("Commenter 6", "Text 6"));
        v2.Comments.Add(new Comment("Commenter 7", "Text 7"));
        v2.Comments.Add(new Comment("Commenter 8", "Text 8"));

        List<Video> videos = new List<Video> { v1, v2 };

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.NumberOfComments()}");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"Commenter: {comment.Commenter}");
                Console.WriteLine($"Text: {comment.Text}");
            }
        }
    }
}