namespace CS4125.Data;

using System.Collections.Generic;

public abstract class Animal
{
    protected enum Sex
    { 
        Male, 
        Female
    }
    
    private int _id;
    private DateOnly _dob;
    private bool _isVaccinated;
    private Sex _sex;
    protected Animal(int id, DateOnly dob, bool isVaccinated, Sex sex)
    {
        _id = id;
        _dob = dob;
        _isVaccinated = isVaccinated;
        _sex = sex;
    }
}
