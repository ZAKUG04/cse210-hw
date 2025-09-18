/*
Word class:
- store the text
- store if visible or hide
*/

public class Word
{
    private string _content;
    private bool _visible;

    public Word(string content)
    {
        _content = content;
        _visible = true;
    }

    public void Hide()
    {
        _visible = false;
    }

    public bool IsHidden()
    {
        return !_visible;
    }

    public string GetText()
    {
        if (_visible) return _content;
        return new string('_', _content.Length);
    }
}