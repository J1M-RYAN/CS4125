namespace CS4125.Data.Animal;

public class Mare : Equine, IFemale
{
    private bool _isPregnant;
    private bool _isSurrogate;

    public Mare(int id, DateTime dob, EquineBreed breed, bool isSurrogate) : base(id, dob, Sex.Female, breed)
    {
        _isSurrogate = isSurrogate;
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

    public bool GetIsSurrogate()
    {
        return _isSurrogate;
    }

    public void SetIsSurrogate(bool isSurrogate)
    {
        _isSurrogate = isSurrogate;
    }
}