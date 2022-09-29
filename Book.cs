public class Book : Product
{
    public string ISBN { get; set; }
    public int PageNumber { get; set; }

    public Book(string title, string author, int pageNumber, string isbn) : base(title, author)
    {
        this.ISBN = isbn;
        this.PageNumber = pageNumber;
    }
}

