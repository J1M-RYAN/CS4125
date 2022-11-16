namespace CS4125.Data.AnimalData;

public interface IFemale
{
    bool IsPregnant { get; set; }

    void ArtificialInsemination();

    bool TestPregnancy();
}