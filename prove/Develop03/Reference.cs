class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;

    public Reference(string book, string chapter, string verse)
    {
        // constructor for references like John 3:16
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, string chapter, string verse, string endVerse)
    {
        // constructor for references like Provers 3:5-6
        _book = book; 
        _chapter = chapter;
        _verse = $"{verse}-{endVerse}";
    }

    public string GetReferenceText()
    {
        // returns a string version of the scripture reference
        return $"{_book} {_chapter}: {_verse}";
    }

    // if want getters/setters
    public string GetBook()
    {
        return _book;
    }
    public void SetBook(string book)
    {
        _book = book;
    }
}   

