using System.Net.Sockets;

public class Scripture{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text) {
        _reference = reference;
        _words = new List<Word>();
        string[] _list = text.Split(" ");
        foreach (string wordString in _list){
            Word word = new Word(wordString);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide){
        Random randomGen = new Random();
        foreach (int value in Enumerable.Range(1, numberToHide))
        {
            int num = randomGen.Next(0, _words.Count());
            _words[num].Hide();
        }
    }

    public string GetDisplayText(){
        string text = "";
        foreach (Word word in _words){
            text = text + " " + word.GetDisplayText();
        }
        return $"{_reference.GetDisplayText()}{text}";
    }

    public bool IsCompletelyHidden(){
        int _counter = 0;
        foreach (Word word in _words) {
            if (word.IsHidden()){
                _counter = _counter + 1;
            }
        }
        if (_counter == _words.Count()){
            return true;
        }
        else {
            return false;
        }
    }
}