public class Ram: Ovine, IMale{
    private bool _isCastrated;
    private double _hornLength;
    public Ram(int id, DateTime dob, OvineBreed _breed) : base(id, dob, Sex.MALE, _breed)
{
    _isCastrated = false;
    _hornLength = 0;
}
    public bool isCastrated { get; set; }
    public void Castrate()
    {
        _isCastrated = true;
    }

    public double GetHornLength()
    {
        return _hornLength;
    }
    public void SetHornLength(double hornLength)
    {
        _hornLength = hornLength;
    }

}