public class Word
{
    public string Hide(List<string> word_list, int random)
    {
        string word = word_list[random];
        int characters = word.Count();
        string item = new string('-', characters);

        return item;
    }
}