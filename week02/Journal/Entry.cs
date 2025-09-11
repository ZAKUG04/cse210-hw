using System;
public class Entry
{
    public string _date;
    public string _prompt;
    public string _text;
    public void Display()
    {
        System.Console.WriteLine($"{_date} - {_prompt}\n{_text}");
    }
    public string ToFileString()
    {
        return $"{_date}|{_prompt}|{_text}";
    }
    public static Entry FromFileString(String line)
    {
        string[] parts = line.Split('|');
        Entry e = new Entry();
        e._date = parts[0];
        e._prompt = parts[1];
        e._text = parts[2];
        return e;
    }
}