namespace CS4125.Data.Animal;

public class Cow : Bovine, IFemale
{
    private bool _isPregnant;
    private double _milkProduction;

    public Cow(int id, DateTime dob, BovineBreed breed, double milkProduction) : base(id, dob, Sex.Female, breed)
    {
        _milkProduction = milkProduction;
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

    public double GetMilkProduction()
    {
        return _milkProduction;
    }

    public void SetMilkProduction(double milkProduction)
    {
        _milkProduction = milkProduction;
    }
}