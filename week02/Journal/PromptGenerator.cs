using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompt = new List<string>()
    {
        "What was the best part of your day?",
        "Who did you talk to today?",
        "What are you grateful for?",
        "What did you learn today?"
    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompt.Count);
        return _prompt[index];
    }
}