namespace CS4125.Data.Animal;

public interface IFemale
{
    bool IsPregnant { get; set; }

    void ArtificialInsemination();

    bool TestPregnancy();
}