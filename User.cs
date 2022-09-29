public class User
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public double MobileNumber { get; set; }
    public bool IsRegistered { get; set; }

    public User(string name, string surname, string email, string password, double mobileNumber)
    {
        Name = name;
        Surname = surname;
        Email = email;
        Password = password;
        MobileNumber = mobileNumber;
    }
}