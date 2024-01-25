public class Word {
    private string _text;
    private bool _isHidden;

    public Word (String text ){
        _text = text;
    }

    public void Hide(){
        _text = new string('_', _text.Length);
        _isHidden = true;
    }

    public void Show(){

    }

    public bool IsHidden(){
        return _isHidden;
    }

    public string GetDisplayText(){
        return _text;
    }

}