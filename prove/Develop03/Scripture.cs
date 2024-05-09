using System.Globalization;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = [];
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] verseArray = text.Split(" ");
        foreach (string word in verseArray)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rng = new Random();
        int numHidden = 0;
        do
        {
            if (isCompletelyHidden())
            {
                break;
            }
            int indexToHide = rng.Next(_words.Count);
            if (!_words[indexToHide].isHidden())
            {
                numHidden += 1;
                _words[indexToHide].Hide();
            }
        } while (numHidden < numberToHide);
    }

    public string GetDisplayText()
    {
        string myString = _reference.GetDisplayText() + " - ";
        foreach (Word word in _words)
        {
            myString += word.GetDisplayText() + " ";
        }
        return myString;
    }

    public bool isCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.isHidden())
            {
                return false;
            }
        }
        return true;
    }
}