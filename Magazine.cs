namespace implvi;

public class Magazine
{
    private static string _publisher;
    private string _name;
    private string _month;
    private int _pages;

    public Magazine(string publisher, string name, string month, int pages)
    {
        _publisher = publisher;
        _name = name;
        _month = month;
        _pages = pages;
    }

    public string publisher => _publisher;
    public string name => _name;
    public string month => _month;
    public int pages => _pages;
}