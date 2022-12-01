namespace CS4125.Data.AnimalData;

public class Bull : Bovine, IMale
{
    private bool _hasBullRing;
    private bool _isCastrated;

    public Bull(int id, DateTime dob, BovineBreed breed) : base(id, dob, Sex.Male, breed)
    {
        _hasBullRing = false;
        _isCastrated = false;
    }

    public bool GetIsCastrated() => _isCastrated;

    public void SetIsCastrated(bool value) => _isCastrated = value;

    public bool GetHasBullRing()
    {
        return _hasBullRing;
    }

    public void SetHasBullRing(bool hasBullRing)
    {
        _hasBullRing = hasBullRing;
    }
}