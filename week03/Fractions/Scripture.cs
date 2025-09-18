using System;
using System.Collections.Generic;
using System.Linq;

/*
Scripture class
- store reference and words
- handle hiding words randomly
*/

public class Scripture
{
    private Reference _reference;
    private List<Word> _wordList;
    private Random _rand;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _rand = new Random();
        _wordList = text.Split(' ').Select(s => new Word(s)).ToList();
    }

    public void HideRandomWords(int count)
    {
        var unhidden = _wordList.Where(w => !w.IsHidden()).ToList();
        if (unhidden.Count == 0) return;

        int toHide = Math.Min(count, unhidden.Count);
        var chosen = unhidden.OrderBy(x => _rand.Next()).Take(toHide);
        foreach (var w in chosen) w.Hide();
    }

    public bool AreAllWordsHidden()
    {
        return _wordList.All(w => w.IsHidden());
    }

    public string GetTextDisplay()
    {
        return $"{_reference.GetFullReference()} - {string.Join(" ", _wordList.Select(w => w.GetText()))}";
    }
    // Returns number of words still visible
    public int VisibleWordsCount()
    {
        return _wordList.Count(w => !w.IsHidden());
    }

    // Return book name for custom message
    public string GetReferenceName()
    {
        return _reference.GetFullReference();
    }
}