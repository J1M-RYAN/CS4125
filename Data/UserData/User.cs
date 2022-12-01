namespace CS4125.Data.UserData;

public abstract class User
{
    public User(string email, string firstName, string lastName)
    {
        Email = email;
        FirstName = firstName;
        LastName = lastName;
    }

    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}