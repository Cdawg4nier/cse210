public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool isHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string newString = "";
            for (int i = 0; i < _text.Length; i++)
            {
                newString += "_";
            }
            return newString;
        }
        else
        {
            return _text;
        }
    }
}