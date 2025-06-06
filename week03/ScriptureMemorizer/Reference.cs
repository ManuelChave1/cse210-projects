public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    
    public Reference()
    {

    }

    public Reference(string book, int chapter)
    {
        _book = book;
        _chapter = chapter;
    }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string  book, int chapter, int verse, int endVerse)
    {
        _book = book;;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }


    public string GetDisplayText()
    {
        string displayText;
        if(_endVerse != 0)
        {
           displayText = _book + " " + _chapter  +  ":" + _verse + "-" + _endVerse;
        }
        else
        {
            displayText = _book + " " + _chapter  +  ":" + _verse;
        }


        return displayText;
    }
} 