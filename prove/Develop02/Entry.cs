class Entry
{
    public string _date;
    public string _prompt;
    public string _text;

    public void Display()
    {
        // display the entry details
        Console.WriteLine($"{_date} | {_prompt} | You wrote: {_text}");
    }
}

// DateTime theCurrentTime = DateTime.Now;
