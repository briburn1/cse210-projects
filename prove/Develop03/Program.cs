using System;

class Program
{
    static void Main(string[] args)
    {
        Reference theRef = new Reference("Helaman", "5", "12");
        string text = "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.";
        Scripture theScripture = new Scripture(theRef, text);
        Word theWord = new Word("");

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
