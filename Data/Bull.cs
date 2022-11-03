public class Bull : Bovine, IMale
{
    private bool _hasBullRing;
    private bool _isCastrated;

    public Bull(int id, DateTime dob, BovineBreed _breed) : base(id, dob, Sex.MALE, _breed)
    {
        this._hasBullRing = false;
        this._isCastrated = false;
    }

    public bool isCastrated { get; set; }

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