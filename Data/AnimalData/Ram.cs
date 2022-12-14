namespace CS4125.Data.AnimalData;

public class Ram : Ovine, IMale
{
    private double _hornLength;
    private bool _isCastrated;
    private double _woolYield;

    public Ram(int id, DateTime dob, OvineBreed breed, double woolYield) : base(id, dob, Sex.Male, breed, woolYield)
    {
        _woolYield = woolYield;
        _isCastrated = false;
        _hornLength = 0;
    }

    public bool GetIsCastrated() => _isCastrated;

    public void SetIsCastrated(bool value) => _isCastrated = value;

    public double GetHornLength()
    {
        return _hornLength;
    }

    public void SetHornLength(double hornLength)
    {
        _hornLength = hornLength;
    }

    public double GetWoolYield()
    {
        return _woolYield;
    }

    public void SetWoolYield(double woolYield)
    {
        _woolYield = woolYield;
    }
}