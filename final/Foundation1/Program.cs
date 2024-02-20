using System;

class Program
{
    static void Main(string[] args)
    {
        
        // List<Video> videos = new List<Video>();
        // for (int i = 0; i < 4; i++) {
        //     Console.WriteLine("Please enter the features of the video:");
        //     Console.Write("Title: ");
        //     string title = Console.ReadLine();
        //     Console.Write("Author: ");
        //     string author = Console.ReadLine();
        //     Console.Write("Length (in seconds): ");
        //     int lenght = int.Parse(Console.ReadLine());
        //     Video newVideo = new Video(title, author, lenght);
        //     videos.Add(newVideo);
        // }
        
        // foreach (Video video in videos) {
        //     Console.WriteLine($"Comments of {video.getTitle()}");
        //     List<Comment> comments = new List<Comment>();
        //     for (int i = 0; i < 4; i++) {
        //         Console.WriteLine("\nPlease enter the features of the comment:");
        //         Console.Write("\nViewer: ");
        //         string viewer = Console.ReadLine();
        //         Console.Write("Content: ");
        //         string text = Console.ReadLine();
        //         Console.WriteLine();
        //         Comment newComment = new Comment(viewer, text);
        //         comments.Add(newComment); 
        //     }
        //     video.setComments(comments);
        // }

        //Create content

        string title1 = "Exploring the Wilderness";
        string title2 = "The Art of Painting";
        string title3 = "Yoga for Beginners";

        string author1 = "Jane Doe";
        string author2 = "Michael Johnson";
        string author3 = "Sarah Williams";

        string lenght1 = "360";
        string lenght2 = "430";
        string lenght3 = "290";

        List<Video> videos = new List<Video>();
        Video newVid1 = new Video(title1, author1, lenght1);
        Video newVid2 = new Video(title2, author2, lenght2);
        Video newVid3 = new Video(title3, author3, lenght3);
        videos.Add(newVid1);
        videos.Add(newVid2);
        videos.Add(newVid3);
        
        List<Comment> comments1 = new List<Comment>();
        Comment newComment1 = new Comment("Alice", "Absolutely stunning scenery! Makes me want to pack my bags and go on an adventure.");
        Comment newComment2 = new Comment("Bob", "I can't believe how beautiful nature is. Thanks for sharing this amazing video!");
        Comment newComment3 = new Comment("Carol", "This video reminds me of my last camping trip. Such fond memories!");
        Comment newComment4 = new Comment("Dave", "The soundtrack is so calming. It perfectly complements the visuals.");
        comments1.Add(newComment1);
        comments1.Add(newComment2);
        comments1.Add(newComment3);
        comments1.Add(newComment4);
        newVid1.setComments(comments1);

        List<Comment> comments2 = new List<Comment>();
        newComment1 = new Comment("Emma", "I wish I had such talent! Watching this makes me want to pick up a paintbrush.");
        newComment2 = new Comment("Frank", "As an aspiring artist, this video is incredibly inspiring. Thank you for sharing your process!");
        newComment3 = new Comment("Grace", "Wow, I never knew painting could be so mesmerizing to watch. You're truly gifted");
        newComment4 = new Comment("Henry", "The way you blend colors is so satisfying to watch. I could watch this for hours.");
        comments2.Add(newComment1);
        comments2.Add(newComment2);
        comments2.Add(newComment3);
        comments2.Add(newComment4);
        newVid2.setComments(comments1);

        List<Comment> comments3 = new List<Comment>();
        newComment1 = new Comment("Isabella", "This is exactly what I needed to start my day feeling refreshed and energized!");
        newComment2 = new Comment("Jack", "Thank you for breaking down the poses step by step. It's making yoga so much more accessible for me!");
        newComment3 = new Comment("Lily", "I've been meaning to start practicing yoga, and this video is the perfect introduction. Thank you!");
        newComment4 = new Comment("Mike", "I never thought I could enjoy yoga, but your clear instructions and calming voice have changed my mind!");
        comments3.Add(newComment1);
        comments3.Add(newComment2);
        comments3.Add(newComment3);
        comments3.Add(newComment4);
        newVid3.setComments(comments1);

        Console.Clear();
        Console.WriteLine("Now showing all the data:");
        foreach (Video video in videos) {
            video.displayFeatures();
        }
    }
}