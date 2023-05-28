public class Scripture
{
    Word _word = new Word();
    Reference _reference;
    public List<string> word_list = new List<string>();
    
    public Scripture(Reference reference, string scripture)
    {
        string[] words = scripture.Split(" ");

        foreach (string word in words)
        {
            word_list.Add(word);
        }
        List<string> original = new List<string>(word_list);
        _reference = reference;
    }

    public void Display()
    {
        string reference = _reference.GetReference();
        Console.WriteLine($"{reference}");
        foreach (string word in word_list)
        {
            Console.Write($"{word} ");
        }
    }

    public void HideRandom()
    {
        var random = new Random();
        var randomNumber = random.Next(0, word_list.Count);

        string replacement = _word.Hide(word_list, randomNumber);
        word_list[randomNumber] = $"{replacement}";
    }

    public bool HiddenCheck()
    {
        bool completed = false;
        int i = 0;

        foreach (string word in word_list)
        {
            if (word.Contains("-") == true)
            {
                i++;
            }
        }

        if (i == word_list.Count())
        {
            completed = true;
        }

        return completed;
    }
}