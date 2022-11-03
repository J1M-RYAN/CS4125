public class Mare : Equine, IFemale
{
    private bool _isPregnant;
    private bool _isSurrogate;

    public Mare(int id, DateTime dob, EquineBreed _breed, bool _isSurrogate) : base(id, dob, Sex.FEMALE, _breed)
    {
        this._isSurrogate = _isSurrogate;
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

    public bool GetIsSurrogate()
    {
        return _isSurrogate;
    }

    public void SetIsSurrogate(bool isSurrogate)
    {
        _isSurrogate = isSurrogate;
    }
}