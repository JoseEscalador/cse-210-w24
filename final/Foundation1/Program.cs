using System;

class Program
{
    static void Main(string[] args)
    {
        //populate videos
        List<Video> videos = new List<Video>();
        for (int i = 0; i < 4; i++) {
            Console.WriteLine("Please enter the features of the video:");
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Author: ");
            string author = Console.ReadLine();
            Console.Write("Length (in seconds): ");
            int lenght = int.Parse(Console.ReadLine());
            Video newVideo = new Video(title, author, lenght);
            videos.Add(newVideo);
        }
        
        foreach (Video video in videos) {
            Console.WriteLine($"Comments of {video.getTitle()}");
            List<Comment> comments = new List<Comment>();
            for (int i = 0; i < 4; i++) {
                Console.WriteLine("\nPlease enter the features of the comment:");
                Console.Write("\nViewer: ");
                string viewer = Console.ReadLine();
                Console.Write("Content: ");
                string text = Console.ReadLine();
                Console.WriteLine();
                Comment newComment = new Comment(viewer, text);
                comments.Add(newComment); 
            }
            video.setComments(comments);
        }
        Console.Clear();
        Console.WriteLine("Now showing all the data: ");
        foreach (Video video in videos) {
            video.displayFeatures();
        }
    }
}