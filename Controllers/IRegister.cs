namespace CS4125.Controllers;

public interface IRegister
{
    public void RegisterFarmer(string email, string firstName, string lastName, string password);
}