class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    Random randomGenerator = new Random();

    public PromptGenerator()
    {
        Prompts();
    }

    // add prompts to list
    public void Prompts()
    {
        string prompt1 = "If I had one thing I could do over today, what would it be?";
        string prompt2 = "What was the strongest emotion I felt today?";
        string prompt3 = "How did I see the hand of the Lord in my life today?";
        string prompt4 = "What was the best part of my day?";
        string prompt5 = "Who was the most interesting person I interacted with today?";
        string prompt6 = "What am I grateful for today?";
        string prompt7 = "How did you manage your stress today?";
        string prompt8 = "How do you feel about your relationships with your family and friends?";
        string prompt9 = "How do you feel about your life right now?";
        string prompt10 = "What is challenging you the most in life right now?";

        _prompts.Add(prompt1);
        _prompts.Add(prompt2);
        _prompts.Add(prompt3);
        _prompts.Add(prompt4);
        _prompts.Add(prompt5);
        _prompts.Add(prompt6);
        _prompts.Add(prompt7);
        _prompts.Add(prompt8);
        _prompts.Add(prompt9);
        _prompts.Add(prompt10);
    }

    public string GetRandomPrompt()
    {
        int index = randomGenerator.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        return randomPrompt;
    }
}