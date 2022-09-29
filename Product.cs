using System.Xml.Linq;

public class Product
{
    public string Title { get; set; }
    public int Year { get; set; }
    public string Category { get; set; }
    public bool IsAvailable { get; set; }
    public string Place { get; set; }
    public string Author { get; set; }

    public Product(string title, string author)
    {
        Title = title;
        Author = author;
    }
}

