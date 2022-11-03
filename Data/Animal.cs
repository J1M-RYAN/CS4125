public abstract class Animal
{
    private readonly DateTime _dateOfBirth;
    private int _id;

    private bool _isVacinated;
    private Sex _sex;

    public Animal(int id, DateTime dob, Sex sex)
    {
        _id = id;
        _dateOfBirth = dob;
        _sex = sex;
    }

    public int GetId()
    {
        return _id;
    }

    public void SetId(int id)
    {
        _id = id;
    }

    public DateTime GetDateOfBirth()
    {
        return _dateOfBirth;
    }
}

public enum Sex
{
    Male,
    Female
}