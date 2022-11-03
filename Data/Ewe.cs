namespace CS4125.Data;

public class Ewe : Ovine, IFemale
{
    private bool _isPregnant;
    private double _woolYield;

    public Ewe(int id, DateTime dob, OvineBreed breed, double woolYield) : base(id, dob, Sex.Female, breed,
        woolYield)
    {
        _woolYield = woolYield;
        _isPregnant = false;
    }

    public void ArtificialInsemination()
    {
        _isPregnant = true;
    }

    public bool TestPregnancy()
    {
        return _isPregnant;
    }

    public bool IsPregnant { get; set; }

    public double GetWoolYield()
    {
        return _woolYield;
    }

    public void SetWoolYield(double woolYield)
    {
        _woolYield = woolYield;
    }
}