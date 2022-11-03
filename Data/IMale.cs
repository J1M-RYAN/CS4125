namespace CS4125.Data;

public interface IMale
{
    bool IsCastrated { get; set; }
    void Castrate();
}