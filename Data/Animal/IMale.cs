namespace CS4125.Data.Animal;

public interface IMale
{
    bool IsCastrated { get; set; }
    void Castrate();
}