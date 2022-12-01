namespace CS4125.Data.AnimalData;

public class Stallion : Equine, IMale
{
    private bool _isCastrated;
    private double _studPrice;

    public Stallion(int id, DateTime dob, EquineBreed breed) : base(id, dob, Sex.Male, breed)
    {
        _studPrice = 0;
    }

    public bool GetIsCastrated() => _isCastrated;

    public void SetIsCastrated(bool value) => _isCastrated = value;

    public double GetStudPrice()
    {
        return _studPrice;
    }

    public void SetStudPrice(double studPrice)
    {
        _studPrice = studPrice;
    }
}