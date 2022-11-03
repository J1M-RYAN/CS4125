namespace CS4125.Data;

public interface IFemale
{
    bool IsPregnant { get; set; }

    void ArtificialInsemination();

    bool TestPregnancy();
}