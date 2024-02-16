public class Comment {
    private string _viewer;
    private string _text;
    
    public Comment (string viewer, string text) {
        _viewer = viewer;
        _text = text;
    }

    public void displayComments() {

    }

    public string getViewer() {
        return _viewer;
    }
    public string getText() {
        return _text;
    }
}