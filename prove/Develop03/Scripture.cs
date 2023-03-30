using System.Collections.Generic;
class Scripture
{
    private Reference _reference;
    public List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        // set variables, including break up the text into parts and for each one, 
        // create a new word object and add it to the list.
        // don't forget to creat a new list (e.g., = new List<Word>();   )
        _words = new List<Word>();
        string[] newText = text.Split(' ');
        foreach (string item in newText)
        {
            Word word = new Word(item);
            _words.Add(word);
        }
        
    }

    public void HideWords(int number)
    {
        // hides "number" words at random
        while (Word._isHidden)
        {
            int i = 0;
            while (i < 5)
            {
                // create random number <5 with random class
                // call word.hide with a while loop
                // if hide word is not hidden 
                Console.WriteLine(i);
                i++;
            }
        }
    }

    public string GetDisplayText()
    {
        // go through each word, call its "GetDisplayText" method and append it to a string
        return "";
    }

    public bool IsCompletelyHidden()
    {
        // figure out if all the words are hidden, if so, return true. If not, return false.
        return false;
    }

}