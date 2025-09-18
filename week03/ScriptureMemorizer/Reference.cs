/*
Reference class
- handle book, chapter and verse(s)
- provide display text
*/

public class Reference
{
    private string _bookName;
    private int _chapterNum;
    private int _verseStart;
    private int _verseEnd;

    public Reference(string book, int chapter, int verse)
    {
        _bookName = book;
        _chapterNum = chapter;
        _verseStart = verse;
        _verseEnd = verse;
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _bookName = book;
        _chapterNum = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    public string GetFullReference()
    {
        if (_verseStart == _verseEnd)
            return $"{_bookName} {_chapterNum}:{_verseStart}";
        else
            return $"{_bookName} {_chapterNum}:{_verseStart}-{_verseEnd}";
    }
}