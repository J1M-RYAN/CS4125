public class Ewe : Ovine, IFemale
{
    private bool _isPregnant;
    private double _woolYield;
    
    public Ewe(int id, DateTime dob, OvineBreed _breed, double _woolYield) : base(id, dob, Sex.FEMALE, _breed)
    {
        this._woolYield = _woolYield;
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

    public bool isPregnant { get; set; }

    public double GetWoolYield()
    {
        return _woolYield;
    }

    public void SetWoolYield(double woolYield)
    {
        _woolYield = woolYield;
    }
}