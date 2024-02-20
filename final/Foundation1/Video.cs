public class Video {
    private string _title;
    private string _author;
    private string _lenght;
    private List<Comment> _comments;

    public void setComments(List<Comment> comments ) {
        _comments = comments;
    }
    public List<Comment> getComments() {
        return _comments;
    }
    public string getTitle() {
        return _title;
    }
    public Video (string title, string author, string lenght) {
        _title = title;
        _author = author;
        _lenght = lenght;
    }

    public void displayComments() {
        foreach (Comment comment in _comments) {
            Console.WriteLine($"Viewer: {comment.getViewer()}");
            Console.WriteLine($"Text: {comment.getText()}:\n");
        }
    }

    public void displayFeatures() {
        Console.WriteLine($"Video Title: {_title}");
        Console.WriteLine($"Video Author: {_author}");
        Console.WriteLine($"Video Lenght(in seconds): {_lenght}\n");
        displayComments();
        Console.WriteLine("\n");
    }



}