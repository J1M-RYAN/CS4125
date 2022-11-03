public class Cow : Bovine, IFemale
{
    private double _milkProduction;
    private bool _isPregnant;

    public Cow(int id, DateTime dob, BovineBreed _breed, double _milkProduction) : base(id, dob, Sex.FEMALE, _breed)
    {
        this._milkProduction = _milkProduction;
        this._isPregnant = false;
    }



    public double GetMilkProduction()
    {
        return _milkProduction;
    }

    public void SetMilkProduction(double milkProduction)
    {
        _milkProduction = milkProduction;
    }

    public void ArtificialInsemination()
    {
        this._isPregnant = true;
    }

    public bool TestPregnancy()
    {
        return _isPregnant;
    }

    public bool isPregnant { get; set; }



}