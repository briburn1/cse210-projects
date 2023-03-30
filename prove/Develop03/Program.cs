using System;

class Program
{
    static void Main(string[] args)
    {
        Reference theRef = new Reference("John", "3", "16");
        string text = "For God so loved the world...";
        Scripture theScripture = new Scripture(theRef, text);
        Word theWord = new Word("for");

        Console.WriteLine(theRef.GetReferenceText());
        Console.WriteLine(theWord.GetDisplayText());
        theWord.HideWord();
        Console.WriteLine(theWord.GetDisplayText());
        Console.WriteLine(theWord.IsHidden());

        foreach (Word word in theScripture._words)
        {
            Console.WriteLine(word.GetDisplayText());
            // call word.hide with a while loop
        }

        // while()
        // {
        //     theScripture.GetDisplayText();
        //     theScripture.HideWords();
        // }
    }
}
