public class Cow : Bovine, IFemale
{
    private bool _isPregnant;
    private double _milkProduction;

    public Cow(int id, DateTime dob, BovineBreed _breed, double _milkProduction) : base(id, dob, Sex.FEMALE, _breed)
    {
        this._milkProduction = _milkProduction;
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

    public double GetMilkProduction()
    {
        return _milkProduction;
    }

    public void SetMilkProduction(double milkProduction)
    {
        _milkProduction = milkProduction;
    }
}