namespace CS4125.Data;

public abstract class User
{
    public User(string email, string firstName, string lastName, string password)
    {
        Email = email;
        FirstName = firstName;
        LastName = lastName;
        Password = password;
    }

    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
}