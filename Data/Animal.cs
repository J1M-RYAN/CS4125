public abstract class Animal
{
    private int _id;
    private DateTime _dateOfBirth;
    private Sex _sex;

    private bool _isVacinated;
    public Animal(int id, DateTime dob, Sex sex)
    {
        this._id = id;
        this._dateOfBirth = dob;
        this._sex = sex;

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
    MALE,
    FEMALE
}