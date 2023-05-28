public class Reference
{
    string _book;
    int _verse1;
    string _verse2;
    int _chapter;

    public Reference(string book, int chapter, int verse1, int verse2)
    {
        _book = book;
        _verse1 = verse1;
        _verse2 = $"-{verse2}";
        _chapter = chapter;
    }

    public Reference(string book, int chapter, int verse1)
    {
        _book = book;
        _verse1 = verse1;
        _verse2 = "";
        _chapter = chapter;
    }

    public string GetReference()
    {
        return $"{_book} {_chapter}:{_verse1}{_verse2}";
    }
}