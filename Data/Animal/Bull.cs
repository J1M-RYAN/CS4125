namespace CS4125.Data.Animal;

public class Bull : Bovine, IMale
{
    private bool _hasBullRing;
    private bool _isCastrated;

    public Bull(int id, DateTime dob, BovineBreed breed) : base(id, dob, Sex.Male, breed)
    {
        _hasBullRing = false;
        _isCastrated = false;
    }

    public bool IsCastrated { get; set; }

    public void Castrate()
    {
        _isCastrated = true;
    }

    public bool GetHasBullRing()
    {
        return _hasBullRing;
    }

    public void SetHasBullRing(bool hasBullRing)
    {
        _hasBullRing = hasBullRing;
    }
}