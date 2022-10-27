namespace CS4125.Data;

public abstract class User
{
    public User(string email, string firstName, string lastName, string password)
    {
        this.email = email;
        this.firstName = firstName;
        this.lastName = lastName;
        this.password = password;
    }

    public string email { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string password { get; set; }
}