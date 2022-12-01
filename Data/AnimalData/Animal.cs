namespace CS4125.Data.AnimalData;

public abstract class Animal
{
    private readonly DateTime _dateOfBirth;
    private readonly Sex _sex;
    private int _id;

    private bool _isVacinated;

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

    public Sex GetSex()
    {
        return _sex;
    }
}

public enum Sex
{
    Male,
    Female
}