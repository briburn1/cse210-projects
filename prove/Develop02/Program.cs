using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator generator = new PromptGenerator();
        DateTime theCurrentTime = DateTime.Now;
        //generator.Prompts();
        

        Console.WriteLine("Hello and welcome to the Journal Program!");
        string choice = "";
        while (choice != "5")
        {
            DisplayMenu();
            Console.WriteLine("Please pick an option: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                // new entry
                Console.WriteLine("Writing a new entry");

                // get new prompt and display
                string prompt = generator.GetRandomPrompt();
                Console.WriteLine(prompt);

                // get the user's response
                Console.Write("> ");
                string response = Console.ReadLine();

                // get current date
                string dateText = theCurrentTime.ToShortDateString();
                string date = dateText;

                // create entry object
                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._prompt = prompt;
                newEntry._text = response;

                // add to journal
                theJournal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                // display
                //Console.WriteLine("Displaying the journal");
                theJournal.Display();
            }
            else if (choice == "3")
            {
                // save
                Console.Write("What is the file name? ");
                string file = Console.ReadLine();

                theJournal.Save(file);
            
            }
            else if (choice == "4")
            {
                // load
                Console.Write("What is the file name? ");
                string file = Console.ReadLine();

                theJournal.Load(file);
                
            }
            else if (choice == "5")
            {
                // quit
            }

        }
        

    }

    static void DisplayMenu()
    {
        Console.WriteLine("1. New Entry");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");
    }
}