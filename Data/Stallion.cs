namespace CS4125.Data
{
    public class Stallion: Equine, IMale
    {
        private double _studPrice;
        private bool _isCastrated;
        public Stallion(int id, DateTime dob, EquineBreed _breed) : base(id, dob, Sex.MALE, _breed)
        {
            _studPrice = 0;
        }

        public bool isCastrated { get; set; }

        public void Castrate()
        {
            _isCastrated = true;
        }

        public double GetStudPrice()
        {
            return _studPrice;
        }
        public void SetStudPrice(double studPrice)
        {
            _studPrice = studPrice;
        }
    }}