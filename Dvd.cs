public class Dvd : Product
{
    public string SerialNumber { get; set; }
    public int Duration { get; set; }

    public Dvd(string title, string author, int duration, string serialNumber) : base(title, author)
    {
        this.SerialNumber = serialNumber;
        this.Duration = duration;
    }
}

