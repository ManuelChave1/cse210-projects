using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _word = new List<Word>();
    
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (string word in text.Split(' '))
        {
            _word.Add(new Word(word));
        }
    }


    public string GetDisplayText()
    {
        string wordsText = " ";

        foreach (Word word in _word)
        {
            wordsText += word.GetDisplayText() + " ";
        }
        wordsText = wordsText.TrimEnd();
        return _reference.GetDisplayText() + " - " + wordsText;
    }

    public void HideRandomWords(int number)
    {

        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _word)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        Random random = new Random();
        
        for (int i = 0; i < number && visibleWords.Count > 0; i++)
            {
                int index = random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index);
            }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _word)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
} 