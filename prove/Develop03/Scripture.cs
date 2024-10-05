public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
     _reference = reference;
     _words = new List<Word>();
     string[] words = text.Split(' ');
     foreach (string word in words)
     {
         _words.Add(new Word(word));
     }   
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> unhiddenWords = _words.Where(w => !w.IsHidden()).ToList();
        if (numberToHide > unhiddenWords.Count)
        {
            numberToHide = unhiddenWords.Count;
        }
            
        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(unhiddenWords.Count);
            unhiddenWords[index].Hide();
            unhiddenWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return $"{_reference.GetDisplayText()} {displayText.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}