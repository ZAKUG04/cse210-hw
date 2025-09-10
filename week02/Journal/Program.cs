using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator generator = new PromptGenerator();

        Entry entry1 = new Entry();
        entry1._date = DateTime.Now.ToShortDateString();
        entry1._prompt = generator.GetRandomPrompt();
        entry1._text = "Today I started my Journal program!";

        myJournal.AddEntry(entry1);

        myJournal.Display();
    }
}