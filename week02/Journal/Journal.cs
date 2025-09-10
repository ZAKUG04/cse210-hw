using System.Collections.Generic;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void Display()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }
}