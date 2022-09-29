public class Library
{
    List<User> RegisteredUsers = new List<User>();

    List<Rent> RegisteredRents = new List<Rent>();

    List<Dvd> Dvds = new List<Dvd>();

    List<Book> Books = new List<Book>();

    // add/remove user
    public void AddUser(User user)
    {
        RegisteredUsers.Add(user);
    }
    public void RemoveUser(User user)
    {
        RegisteredUsers.Remove(user);
    }

    // add/remove rent
    public void AddRent(Rent rent)
    {
        RegisteredRents.Add(rent);
    }
    public void RemoveRent(Rent rent)
    {
        RegisteredRents.Remove(rent);
    }

    // add/remove dvd
    public void AddMovie(Dvd dvd)
    {
        Dvds.Add(dvd);
    }
    public void RemoveDvd(Dvd dvd)
    {
        Dvds.Remove(dvd);
    }

    // add/remove book
    public void AddBook(Book book)
    {
        Books.Add(book);
    }
    public void RemoveBook(Book book)
    {
        Books.Remove(book);
    }

    public List<Product> SearchProduct(string searchInput)
    {
        List<Product> resultsList = new List<Product>();
        foreach (Dvd dvd in Dvds)
        {
            if (dvd.Title.Contains(searchInput))
            {
                resultsList.Add(dvd);
            }
        }
        foreach (Book book in Books)
        {
            if (book.Title.Contains(searchInput))
            {
                resultsList.Add(book);
            }
        }
        return resultsList;
    }
}