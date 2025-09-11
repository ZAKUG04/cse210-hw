using System;

class Program
{
static void Main()
{
    Journal myJournal = new Journal();
    PromptGenerator generator = new PromptGenerator();

    bool running = true;

    while (running)
    {
        Console.WriteLine("\nJournal Menu:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display journal");
        Console.WriteLine("3. Save journal to file");
        Console.WriteLine("4. Load journal from file");
        Console.WriteLine("5. Exit");
        Console.Write("Choose an option: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Entry entry = new Entry();
                entry._date = DateTime.Now.ToString("g");
                entry._prompt = generator.GetRandomPrompt();
                Console.WriteLine(entry._prompt);
                Console.Write("Your answer: ");
                entry._text = Console.ReadLine();
                myJournal.AddEntry(entry);
                Console.WriteLine($"\nEntry saved! You now have {myJournal._entries.Count} entries.");
                break;

            case "2":
                myJournal.Display();
                break;

            case "3":
                Console.Write("Enter filename to save: ");
                string saveFile = Console.ReadLine();
                myJournal.Save(saveFile);
                break;

            case "4":
                Console.Write("Enter filename to load: ");
                string loadFile = Console.ReadLine();
                myJournal.Load(loadFile);
                break;

            case "5":
                running = false;
                break;

            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }
}
}
