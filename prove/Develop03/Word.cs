class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public string GetDisplayText()
    {
        // returns the text of the word or else returns ______
        return _text;
    }
 
    public void HideWord()
    {
        // set isHidden to true
        _text = new string('_', _text.Length);
        _isHidden = true;
    }

    public void ShowWord()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

}