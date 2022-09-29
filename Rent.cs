public class Rent
{
    public string RentStart { get; set; }
    public string RentStop { get; set; }
    public User User { get; set; }
    public Product Product { get; set; }

    public Rent(string rentStart, string rentStop, User user, Product product)
    {
        RentStart = rentStart;
        RentStop = rentStop;
        User = user;
        Product = product;
    }
}