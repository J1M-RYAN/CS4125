namespace CS4125.Data.AnimalData;

public interface IMale
{
    bool IsCastrated { get; set; }
    void Castrate();
}