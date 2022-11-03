public interface IFemale
{
    bool IsPregnant { get; set; }

    void ArtificialInsemination();

    bool TestPregnancy();
}