using System.IO;
class Journal
{
    public List<Entry> _entries;
    
    public Journal ()
    {
        _entries = new List<Entry>();
    }
    
    public void Display()
    {
        // go through each entry and display
        //Console.WriteLine("Displaying the journal");
        //Console.WriteLine(_entries);
        foreach (Entry e in _entries)
        {
            e.Display();
        
        }
    }

    public void Save(string file)
    {
        // save all entries to file        
        Console.WriteLine($"Saving journal to file {file}");

        // open file
        string filename = file;
        string[] lines = System.IO.File.ReadAllLines(filename);
        // go through entries
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string _date = parts[0];
            string _prompt = parts[1];
            string _text = parts[2];
        
        //for each one:
            // get stirng that represents entry
            // possible format: "date | prompt | text"

            // write string to file
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine($"Date: {_date} | Prompt: {_prompt} | You wrote: {_text}");
            }
        }
        // make sure file is closed
    }

    public void Load(string file)
    {
        // load all entries from file
        Console.WriteLine($"Loading journal file {file}");
        // clear entries list to empty it
        _entries.Clear();
        // open file
        string filename = file;
        string[] lines = System.IO.File.ReadAllLines(filename);
        // go through each line
        // line should look like: "date | prompt | text"
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string date = parts[0];
            string prompt = parts[1];
            string text = parts[2];
        
        // Break up the line into its parts
        // save parts into an array/list
        // create variables for each part

        // create a new entry
        // set values to be variables 
            Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._prompt = prompt;
                newEntry._text = text;
        // add the new entry to the list
            AddEntry(newEntry);
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine($"Date: {date} | Prompt: {prompt} | You wrote: {text}");
            }
        }
    }

    public void AddEntry(Entry entry)
    {
        // add entry to list
        _entries.Add(entry);
    }
}