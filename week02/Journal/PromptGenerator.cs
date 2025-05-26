using System;
using System.Collections.Generic;

public class PromptGenerator
{
    
    public List<string> _prompts = new List<string>
    {
        "What am I grateful for today?",
        "What was the best thing that happened today?",
        "What did I learn today?",
        "What did I do today that I am proud of?",
        "What was the most challenging thing I faced today?",
        "What happened today?"
    };

    public Random random = new Random();
    public string GetRandomPrompt()
    {
        int ranNum = random.Next(0, _prompts.Count);
        return _prompts[ranNum];
    }
}